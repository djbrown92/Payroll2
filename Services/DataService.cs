using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payroll2.Models;

namespace Payroll2.Services
{
    public class DataService : IDataService
    {
        private readonly List<Employee> lstEmployee = new List<Employee>();
        public DataService()
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.FirstName = "Joydip";
            employee.LastName = "Kanjilal";
            employee.Address = "India";
            lstEmployee.Add(employee);
        }
        public List<Employee> Get()
        {
            if (lstEmployee.Count > 0)
                return lstEmployee;
            return null;
        }
        public Employee GetById(int id)
        {
            foreach (var emp in lstEmployee)
            {
                if (emp.Id == id)
                    return emp;
            }
            return null;
        }
    }
}
