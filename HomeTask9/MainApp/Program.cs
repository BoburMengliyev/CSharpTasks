using Infrastructure.Services;
using Domain.Models;
using System;

class Program
{
    static void Main()
    {
        var departmentService = new DepartmentService();
        var employeeService = new EmployeeService();

        var department = new Department
        {
            Name = "IT",
            Description = "Texnik bo‘lim",
            Manager = null 
        };

        departmentService.AddDepartment(department);

        var employee = new Employee
        {
            Firstname = "Ali",
            Lastname = "Karimov",
            BirthDate = new DateTime(1995, 3, 25),
            Salary = 2500m,
            Department = department
        };

        employeeService.AddEmployee(employee);

        Console.WriteLine($"Xodimlar soni: {employeeService.CountEmployees()}");
        Console.WriteLine($"Bo‘limlar soni: {departmentService.CountDepartments()}");
        Console.ReadKey();
    }
}