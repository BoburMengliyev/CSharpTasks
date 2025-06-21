using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask.Animal
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void Greets()
        {
            Console.WriteLine("Meow");
        }
    }
}
