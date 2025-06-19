using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13.Person
{
    internal class Student : Person
    {
        public Student(string name) : base(name)
        { }

        public void Study() 
        {
            Console.WriteLine("The student is studying");
        }
    }
}
