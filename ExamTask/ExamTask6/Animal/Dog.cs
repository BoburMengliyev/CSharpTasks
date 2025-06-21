using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask.Animal
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void Greets()
        {
            Console.WriteLine("Woof");
        }

        public virtual void Greets(Dog absd)
        {
            Console.WriteLine("Woooof");
        }
    }
}
