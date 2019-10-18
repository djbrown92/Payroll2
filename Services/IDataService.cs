using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payroll2.Models;

namespace Payroll2.Services
{
    public interface IDataService
    {
        List<Employee> Get();
        Employee GetById(int id);
    }
}
