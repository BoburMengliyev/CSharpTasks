using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask16.Task3
{
    public class Thermostat : IDevice
    {
        public double Temperature { get; set; }
        public double TargetTemperature { get; set; }

        public void SetTemperature(double t) 
        {
            this.Temperature = t;
        }

        public void GetStatus() 
        {
            Console.WriteLine($"Termostat: {Temperature}");
        }

        public void TurnOn()
        {
            Console.WriteLine("Thermostat Yondi");
        }

        public void TurnOff()
        {
            Console.WriteLine("Thermostat O`chdi");
        }
    }
}