using Org.BouncyCastle.Asn1.Sec;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportingTocsv
{

     class List_of_PTB1
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }
        public DateTime dates { get; set; } = DateTime.Now;
        public byte[] image { get; set; }
        public string name { get; set; }
        public string secName { get; set; } 
        // public string presence { get; set; }

    }
}
