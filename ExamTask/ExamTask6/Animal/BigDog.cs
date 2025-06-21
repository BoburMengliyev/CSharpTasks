using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask.Animal
{
    internal class BigDog : Dog
    {
        public BigDog(string name) : base(name) { }

        public override void Greets()
        {
            Console.WriteLine("Wooow");
        }

        public override void Greets(Dog absd)
        {
            Console.WriteLine("Wooooow");
        }

        public void Greets(BigDog absd)
        {
            Console.WriteLine("Wooooooooow");
        }
    }
}
