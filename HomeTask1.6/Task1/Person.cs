using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask16.Task1
{
    public class Person
    {
        public Person(int age)
        {
            Age = age;
        }

        public int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public int SetAge(int age)
        {
            this.Age = age;
            return this.Age;
        }
    }
}
