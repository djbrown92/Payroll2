using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll2.Models
{
    public class Inventory
    {
        public int compnum { get; set; }
        public string inventoryref { get; set; }
        public string whousecode { get; set; }
        public float inventoryqty { get; set; }
    }
}
