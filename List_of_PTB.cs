using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportingTocsv
{
    [Table("User")]
    class List_of_PTB
    {
        [PrimaryKey,AutoIncrement,Column("_id")]
        public int Id { get; set; }
        public DateTime dates { get; set; } = DateTime.Now;
        public string name { get; set; }    
        public string presence { get; set; }
        
    }
    class List_of_PTB1s
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }
        public DateTime dates { get; set; } = DateTime.Now;
        public string name { get; set; }
       // public string presence { get; set; }

    }
}
