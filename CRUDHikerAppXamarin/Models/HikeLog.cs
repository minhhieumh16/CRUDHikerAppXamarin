using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUDHikerAppXamarin.Models
{
    public class HikeLog
    {
        // primary key from sqlite
        [PrimaryKey, AutoIncrement]
        public int HikeLogId { get; set; }
        public string HikeName { get; set; }
        public string Location { get; set; }
        public Date DateOfHike { get; set; }
        public string Parking { get; set; }
        public string Length { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
    }
}
