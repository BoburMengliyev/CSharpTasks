using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12.ClassesTwo
{
    internal class CargoPlane : Airplane
    {
        public int MaxCargoWeight { get; set; }

        public CargoPlane(string name, int capacity, double speed, int year, int MaxCargoWeight) : base(name, capacity, speed, year)
        {
            this.MaxCargoWeight = MaxCargoWeight;
        }

        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Cargo Plane with {MaxCargoWeight}kg max cargo weight");
        }
    }
}
