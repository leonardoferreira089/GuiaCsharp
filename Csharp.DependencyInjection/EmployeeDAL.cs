using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DependencyInjection
{
    public interface IEmployeeDAL 
    {
        List<Employee> SelectAllEmployees();
    }

    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>();

            ListEmployees.Add(new Employee() { Id = 1, Name = "Jorge", Department = "IT" });
            ListEmployees.Add(new Employee() { Id = 2, Name = "João", Department = "HR" });
            ListEmployees.Add(new Employee() { Id = 3, Name = "Guillherme", Department = "Payroll" });

            return ListEmployees;           //returns the list of Employees.
        }
    }
}
