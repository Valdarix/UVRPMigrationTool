using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVRPV2tov3Migration
{
    public class PlayerData
    {
        public string DiscordName { get; set; }
        public string License { get; set; }
        public string CitizenID { get; set; }
       
        public string CharInfo { get; set; }
        public string PlayerName { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();


    }

    public class CharInfo
    {
      //{"gender":0,"birthdate":"1992-11-25","phone":"2984810102","cid":1,"account":"US07QBCore4650162099","nationality":"United States","lastname":"Dave","firstname":"Super","backstory":"placeholder backstory"}
        
        public string Firstname { get; set; }
        public string Lastname { get; set; }    
    }
}
