using System;
using EmployeeEntity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepositary
{
    public class Repositary
    {
        public static List<Employee> employees = new List<Employee>();
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
        public static IEnumerable<Employee> GetEmployee()
        {
            return employees;
        }
    }
}
