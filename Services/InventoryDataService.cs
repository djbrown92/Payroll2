using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payroll2.Models;

namespace Payroll2.Services
{
    public class InventoryDataService : IInventoryDataService
    {
        public List<Inventory> Get()
        {
            throw new NotImplementedException();
        }

        public List<Inventory> GetByCompnum(int compnum)
        {
            throw new NotImplementedException();
        }

        public Inventory GetByCompnumInvref(int compnum, string invref)
        {
            Inventory inventory = new Inventory();
            inventory.compnum = compnum;
            inventory.inventoryref = invref;
            return inventory;
        }
    }
}
