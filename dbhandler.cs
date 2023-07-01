using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Data;

namespace UVRPV2tov3Migration
{
    internal class DB
    {
        public static DataTable GetDataReader(string s, string u, string d, string q)
        {
            MySqlConnection conn;

            string connStr = $"server={s};user={u};database={d};port=3306";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                // perform database operations here...
                string sql = q;  // Replace with your SQL query
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                using IDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                var dt = new DataTable();
                dt.Load(rdr);
                return dt;
            }
            catch (Exception ex)
            {

            }
            return new DataTable();
        }

        public static DataTable GetDataReaderNewDB(string s, string u, string d, string q)
        {
            MySqlConnection conn;

            string connStr = $"server={s};user={u};database={d};port=3306";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                // perform database operations here...
                string sql = q;  // Replace with your SQL query
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                using IDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                var dt = new DataTable();
                dt.Load(rdr);
                return dt;
            }
            catch (Exception ex)
            {

            }
            return new DataTable();
        }

        public static void UpdateData(string s, string u, string d, string newStash, string citizenID, string stashID, string NewMoney)
        {
            string connStr = $"server={s};user={u};database={d};port=3306";
            string updateSql = $"UPDATE StashItems SET Items = '{newStash}' WHERE Stash = '{stashID}'";
            string updateSqlMoney = $"UPDATE players SET Money = '{NewMoney}' WHERE CitizenID = '{citizenID}'";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(updateSql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                using (MySqlCommand cmd = new MySqlCommand(updateSqlMoney, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static string GetStrData(DataRow dataRow, string field)
        {
            var result = string.Empty;
            result = dataRow[field].ToString();
            return result;
        }

        public static int GetIntData(DataRow dataRow, string field)
        {
            var result = 0;
            if (GetStrData(dataRow, field) == null || GetStrData(dataRow, field).Trim() == "") return 0;
            result = int.Parse(dataRow[field].ToString());
            return result;
        }

        public static PlayerData LoadPlayer(DataRow row)
        {
            var player = new PlayerData
            {
                CitizenID = $"{row["CitizenID"]}",
                License = $"{row["License"]}",
                DiscordName = $"{row["NAME"]}",
                CharInfo = $"{row["CharInfo"]}" // this is a JSON string Currently. We will need to parse it later. 
            };
            return player;
        }

        public static Vehicle LoadPlayerVehicles()
        {           
            var v = new Vehicle
            {
                ID = "",
                Price = "",
                Balance = ""
            };         
            return v;
        }



    }
}
