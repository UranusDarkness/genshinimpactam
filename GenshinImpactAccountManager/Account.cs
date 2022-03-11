using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinImpactAccountManager
{
    public class Account
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Rank { get; set; }
        public long AcquaintFate { get; set; }
        public long IntertwinedFate { get; set; }
        public long Primogems { get; set; }
        public long GenesisCrystals { get; set; }
        public string Gender { get; set; }

        public string Server { get; set; }

        public string Fivestars { get; set; }
        public string Fourstars { get; set; }


        public Account()
        {

        }
    }
}
