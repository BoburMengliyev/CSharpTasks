using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask16.Task1
{
    public class Teacher : Person
    {
        public Teacher(int age) : base(age)
        { }
        public void Explain() 
        {
            Console.WriteLine("I'm explaining");
        }
    }
}
