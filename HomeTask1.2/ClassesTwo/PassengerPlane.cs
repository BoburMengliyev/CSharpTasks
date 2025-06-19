using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12.ClassesTwo
{
    internal class PassengerPlane : Airplane
    {
        public int FlightRange { get; set; }

        public PassengerPlane(string name, int capacity, double speed, int year, int FlightRange) : base(name, capacity, speed, year)
        {
            this.FlightRange = FlightRange;
        }

        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Passenger Plane with {FlightRange}km flight range");
        }
    }
}
