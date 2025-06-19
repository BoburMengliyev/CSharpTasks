using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12.ClassesTwo
{
    internal class PassengerCar : Car
    {
        public int NumberofSeates { get; set; }

        public PassengerCar(string name, int capacity, double speed, int year, int NumberofSeates) : base(name, capacity, speed, year)
        {
            this.NumberofSeates = NumberofSeates;
        }

        public void GetInfo() 
        {
            base.GetInfo();
            Console.WriteLine($"Passenger Car with {NumberofSeates} seats");
        } 
    }
}
