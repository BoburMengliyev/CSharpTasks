using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12.ClassesTwo
{
    internal class CargoCar : Car
    {
        public int LoadCapacity { get; set; }

        public CargoCar(string name, int capacity, double speed, int year, int LoadCapacity) : base(name, capacity, speed, year)
        {
            this.LoadCapacity = LoadCapacity;
        }

        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Cargo Car with {LoadCapacity}kg load capacity");
        }
    }
}
