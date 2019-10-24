using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payroll2.Models;

namespace Payroll2.Services
{
    public interface IInventoryDataService
    {
        List<Inventory> Get();
        List<Inventory> GetByCompnum(int compnum);
        Inventory GetByCompnumInvref(int compnum, string invref);
    }
}
