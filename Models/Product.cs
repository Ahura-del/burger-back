using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLAPICore.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Pic {get; set; }
        public string Info {get; set; }
        public string Price {get; set;}
        public int Count {get; set;}
    }
}
