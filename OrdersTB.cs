using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportingTocsv
{
    [Table("OrdersTB")]
    internal class OrdersTB
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public byte[] image { get; set;}
        public string name { get; set; }
        public string date { get; set; }
        public string time { get; set; }
    }
}
