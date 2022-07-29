using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DependencyInjection
{
    public class EmployeeBL
    {
        public IEmployeeDAL _employeeDAL;
        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public List<Employee> GetAllEmployees()         
        {            

            return _employeeDAL.SelectAllEmployees();    
        }
    }
}
