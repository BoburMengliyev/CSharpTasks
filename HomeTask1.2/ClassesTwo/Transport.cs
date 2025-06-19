using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12.ClassesTwo
{
    internal class Transport
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        public Transport(string name, int capacity, double speed, int year)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Speed = speed;
            this.Year = year;
        }

        public void GetInfo() 
        {
            Console.WriteLine($"Transport: {Name}, Capacity: {Capacity}, Speed: {Speed}, Year: {Year}");
        }
    }
}
