using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12.ClassesTwo
{
    internal class Train : Transport
    {
        public int Wagons { get; set; }
        public Train(string name, int capacity, double speed, int year, int wagons) : base(name, capacity, speed, year)
        {
            this.Wagons = wagons;
        }

        public void DisplayInfo() 
        {
            base.GetInfo();
            Console.WriteLine($"Train with {Wagons} wagons");
        }
    }
}
