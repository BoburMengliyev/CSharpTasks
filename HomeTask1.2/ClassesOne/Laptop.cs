using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12.ClassesOne
{
    internal class Laptop : Computer
    {
        private int batteryLife;

        public Laptop(string brand, string processor, int ram, int batteryLife) : base(brand, processor, ram)
        {
            this.batteryLife = batteryLife;
        }

        public void Charge() 
        {
            Console.WriteLine($"{brand} laptop is charging. Batterylife: {batteryLife} hours");
        }
    }
}
