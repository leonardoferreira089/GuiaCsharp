using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DependencyInjection
{
    public class EmployeeBL
    {
        public EmployeeDAL employeeDAL;

        public List<Employee> GetAllEmployees()
        {
            employeeDAL = new EmployeeDAL();

            return employeeDAL.SelectAllEmployees();
        }
    }
}
