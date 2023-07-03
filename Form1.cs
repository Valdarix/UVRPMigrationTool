using MySql.Data.MySqlClient;
using System.Data;
using Newtonsoft.Json;
using NLua;
using System.Text.RegularExpressions;
using System.Numerics;

namespace UVRPV2tov3Migration
{
    public partial class LoadNext : Form
    {
        private DataTable rawData;
        private List<PlayerData> players = new List<PlayerData>();
        private List<Vehicle> allVehicles = new List<Vehicle>();
        private string NewStash;
        private string NewMoney;

        private int TotalValueOfVehicles = 0;


        public LoadNext()
        {
            InitializeComponent();
            connStatus.Text = "Please Connect to a database...";            
        }         
             

        private void ResetFields()
        {
            CitizenID.ResetText();
            PlayerLiscense.ResetText();
            TotalValueOfVehicles = 0;
            NewStash = string.Empty;
        }

        private void LoadData(object sender, EventArgs e)
        {
            // This method is used to load the source data form the old/backup database.
            var qry = $"SELECT CitizenID, License, NAME, CharInfo FROM Players";
            var reader = DB.GetDataReader(edtServer.Text, UserName.Text, DBame.Text, qry);

            foreach (DataRow row in reader.Rows)
            {
                // Get Player Names for the drop down
                var CurrCharInfo = JsonConvert.DeserializeObject<CharInfo>(DB.GetStrData(row, "CharInfo") ?? string.Empty);
                var CurrentPlayerName = $"{CurrCharInfo.Firstname} {CurrCharInfo.Lastname}";              

                //Put the PlayerData into an array.
                var p = DB.LoadPlayer(row);
                p.PlayerName = CurrentPlayerName;

                CharacterSelect.Items.Add(p.PlayerName);

                players.Add(p);
            }

            connStatus.Text = $"Data Loaded from Source";
            connStatus.ForeColor = Color.Green;
            LoadSource.Enabled = false;
            CharacterSelect.SelectedIndex = 0;
        }

        private void CharacterSelect_TextChanged(object sender, EventArgs e)
        {
            ResetFields();
            if (CharacterSelect.Items.Count == 0)
            {
                MessageBox.Show("Please load the player data before selecting a player");
                return;
                
            }
            if (CharacterSelect.Text == "")
            {
                MessageBox.Show("No Player has been selected");
                return;
            }

            // if we have a player. Pull their PlayerData and populate the Selected player fiels. 
            var player = players.SingleOrDefault(p => p.PlayerName == CharacterSelect.Text);
            CitizenID.Text = player?.CitizenID;
            PlayerLiscense.Text = player?.License;

            // Now that we have loaded the player base data we can pull the players cars, money, invetorys, etc. 

            //Firs we will get the amount spent on vehicles before adujusting for payments made
            var lua = new Lua();

           var scriptRaw = File.ReadAllText(OVLPathText.Text);
            scriptRaw = Regex.Replace(scriptRaw, @",\s*['""]hash['""]\s*=\s*`[^`]+`", "");
            scriptRaw = scriptRaw.Replace("`", "");


            lua.DoString(scriptRaw);

            if (lua["QBShared.Vehicles"] is LuaTable vehicles)
                foreach (KeyValuePair<object, object> vehicle in vehicles)
                {
                    var properties = vehicle.Value as LuaTable;
                    var currCar = new Vehicle()
                    {
                        ID = $"\t{vehicle.Key}",
                        Price = $"{properties?["price"]}"
                    };
                    allVehicles.Add(currCar);
                }

            // Now that we have the price list, lets see what the player has and use the balances to determine how much money they need reimbursed. Also determine the contents of the iventories and store them.
            var qry = $"SELECT License, CitizenID, Vehicle, pv.Plate, ti.items AS TrunkStorage, gb.items AS GloveBoxStorage, balance FROM Player_vehicles as pv left join trunkitems AS ti ON pv.plate = ti.plate left JOIN gloveboxitems AS gb ON pv.plate = gb.plate WHERE citizenID = '{CitizenID.Text}'";
            var reader = DB.GetDataReader(edtServer.Text, UserName.Text, DBame.Text, qry);
            
            foreach (DataRow row in reader.Rows)
            {
                var currPlayer = players.FirstOrDefault(p => p.CitizenID == $"{row["CitizenID"]}");
                // See what car they drive, get the price. Deduct the balance,
                var currPlayerCar = $"{row["Vehicle"]}";
                var currPlayerCarBalance = $"{row["balance"]}";
                var vehicleLookup = allVehicles.FirstOrDefault(v => v.ID == $"\t{currPlayerCar}");
                var currPlayerCarPrice = vehicleLookup?.Price;
                if (currPlayerCarPrice != null)
                {
                    var currPlayerReimburse = int.Parse(currPlayerCarPrice) - int.Parse(currPlayerCarBalance);

                    // Add itmes to their inventory for later processing what is left to reimburse

                    if (row["TrunkStorage"] != DBNull.Value)
                        currPlayer?.Inventory.Add($"{row["TrunkStorage"]}");
                    if (row["GloveBoxStorage"] != DBNull.Value)
                        currPlayer?.Inventory.Add($"{row["GloveBoxStorage"]}");

                    //This is the amount needed to be reimbursed for cars. 
                    TotalValueOfVehicles = TotalValueOfVehicles + currPlayerReimburse;
                }
            }
            remiburseAmt.Text = TotalValueOfVehicles.ToString();


            string qryStash = $"SELECT players.CitizenId, players.NAME, Items as StashStorage FROM players LEFT Join Apartments AS ap ON players.CitizenId = ap.CitizenID LEFT JOIN stashitems AS SI ON ap.name = SI.stash WHERE ap.citizenID = '{CitizenID.Text}'";
            var readerStash = DB.GetDataReader(edtServer.Text, UserName.Text, DBame.Text, qryStash);

            // Now that we have the car inventory and the total needing reimbursed to the vehicles lets check the player apartment stash
            foreach (DataRow rowStash in readerStash.Rows)
            {
                var currPlayer = players.FirstOrDefault(p => p.CitizenID == $"{rowStash["CitizenID"]}");
                if (rowStash["StashStorage"] != DBNull.Value)
                    currPlayer?.Inventory.Add($"{rowStash["StashStorage"]}");
            }

            //Now to be really clever we can connect to the new DB and combine that stash inventory as well. It will also give us the inventory stash number for the new database
            //newStash from new database
            var qryNewStash = $"SELECT players.CitizenId, stash, Items as StashStorage, money FROM players LEFT Join Apartments AS ap ON players.CitizenId = ap.CitizenID LEFT JOIN stashitems AS SI ON ap.name = SI.stash WHERE ap.citizenID = '{CitizenID.Text}'";
            var readerNewStash = DB.GetDataReaderNewDB(destinationServer.Text, destinationUser.Text, destinationDB.Text, qryNewStash);

            var playerMoneyObject = "";
            // Now that we have the car inventory and the total needing reimbursed to the vehicles lets check the player apartment stash
            foreach (DataRow rowNewStash in readerNewStash.Rows)
            {
                var currPlayer = players.FirstOrDefault(p => p.CitizenID == $"{rowNewStash["CitizenID"]}");
                if (rowNewStash["StashStorage"] != DBNull.Value)
                    currPlayer?.Inventory.Add($"{rowNewStash["StashStorage"]}");
                if (rowNewStash["Stash"] != DBNull.Value)
                    newStash.Text = $"{rowNewStash["Stash"]}";
                playerMoneyObject =  $"{rowNewStash["money"]}";
            }

            //parse our money add it to the reimbursement total and update the players new money value. 
            dynamic parsed = JsonConvert.DeserializeObject(playerMoneyObject);
            if (parsed != null)
            {
                parsed.bank = parsed.bank + TotalValueOfVehicles;
                newBankVal.Text = parsed.bank;
                NewMoney = JsonConvert.SerializeObject(parsed);
            }

            if (player != null) CombineJSONInventory(player);
        }

        private void CombineJSONInventory(PlayerData player)
        {
            // Finally we are going to do an inventory parse to put everything in a single inventory string. 
            var combined = new List<dynamic>();
            foreach (var list in player.Inventory.Select(jsonString => JsonConvert.DeserializeObject<List<dynamic>>(jsonString)))
            {
                // Combine these lists
                if (list != null) combined.AddRange(list);
            }

            // Convert the combined list back into a JSON string
            var combinedJson = JsonConvert.SerializeObject(combined);

            // Parse the combined JSON string into a list of objects
            var combinedList = JsonConvert.DeserializeObject<List<dynamic>>(combinedJson);

            // Load the LUA file content
            var luaItems = GetLUAItems(NewItemsLUA.Text);

            // Use a loop to check each object in the combined list
            if (combinedList != null)
            {
                for (var i = combinedList.Count - 1; i >= 0; i--)
                {
                    // If the object is not in the LUA file content, remove it
                    if (!luaItems.ContainsKey((string)combinedList[i].name))
                    {
                        combinedList.RemoveAt(i);
                    }
                }

                // Convert the list back into a JSON string
                combinedJson = JsonConvert.SerializeObject(combinedList);
            }

            // Parse the JSON string into a list of dynamic objects
            var items = JsonConvert.DeserializeObject<List<dynamic>>(combinedJson);

            // Initialize the slot counter
            var slotCounter = 1;

            // Loop through each item in the list
            if (items != null)
            {
                foreach (var item in items)
                {
                    // Update the slot number for the current item
                    item.slot = slotCounter++;
                }

                // Convert the updated list back into a JSON string
                var updatedJson = JsonConvert.SerializeObject(items);
                NewStash = updatedJson;
            }
            var updateSql = $"\nUPDATE StashItems SET Items = '{NewStash}' WHERE Stash = '{newStash.Text}' ";
            var updateSqlMoney = $" UPDATE players SET Money = '{NewMoney}' WHERE CitizenID = '{CitizenID.Text}'";
            rt1.Text = updateSqlMoney;
            rt1.Text += updateSql;
            
        }
        private Dictionary<string, dynamic> GetLUAItems(string luaFilePath)
        {
            // Create a new Lua interpreter
            using (var lua = new Lua())
            {
                // Load the LUA file
                lua.DoFile(luaFilePath);

                // Retrieve the items table
                var luaItemsTable = lua.GetTable("QBShared.Items");

                // Convert the LUA table to a .NET dictionary
                // Convert the LUA table to a .NET dictionary
                var luaItemsDict = new Dictionary<string, object>();
                foreach (var key in luaItemsTable.Keys)
                {
                    var item = luaItemsTable[key] as LuaTable;
                    if (item != null)
                    {
                        luaItemsDict[key.ToString()] = item["name"];  // or you may want to save the entire item as value
                    }
                }

                return luaItemsDict;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CharacterSelect.Items.Count <= 0) return;
            
            if (CharacterSelect.SelectedIndex < CharacterSelect.Items.Count - 1)
            {
                CharacterSelect.SelectedIndex += 1;
                NextButton.Enabled = true;
            }
            else
            {
                // If it's the last item, disable the button
                NextButton.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB.UpdateData(destinationServer.Text,destinationUser.Text, destinationDB.Text, NewStash, CitizenID.Text, newStash.Text, NewMoney);
            if (CharacterSelect.Items.Count <= 0) return;
            
            if (CharacterSelect.SelectedIndex < CharacterSelect.Items.Count - 1)
            {
                CharacterSelect.SelectedIndex += 1;
                NextButton.Enabled = true;
            }
            else
            {
                // If it's the last item, disable the button
                NextButton.Enabled = false;
            }
        }
    }
       
}