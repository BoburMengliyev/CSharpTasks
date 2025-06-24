using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask16.Task1
{
    public class Student : Person
    {
        public Student(int age) : base(age) 
        {
            base.Age = age;
        }

        public void Study() 
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge() 
        {
            Console.WriteLine($"My age is: {Age} years old");
        }
    }
}