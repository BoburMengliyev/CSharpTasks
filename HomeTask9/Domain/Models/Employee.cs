using System;

namespace Domain.Models
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public Department Department { get; set; } // Bu pastda yaratiladigan class
    }
}
