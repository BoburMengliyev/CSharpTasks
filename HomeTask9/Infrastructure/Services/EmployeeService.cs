using Domain.Models;

using Domain.Models;
using System.Collections.Generic;

namespace Infrastructure.Services
{
    public class EmployeeService
    {
        private List<Employee> employees = new List<Employee>();

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public int CountEmployees()
        {
            return employees.Count;
        }
    }
}