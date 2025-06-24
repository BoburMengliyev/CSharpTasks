using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask16.Task3
{
    public class Lamp : IDevice
    {
        public int Brightness { get; set; }
        public string Color { get; set; }
        public void SetBrightness(int brightness) 
        {
            this.Brightness = brightness;
        }
        public void ChangeColor(string color) 
        {
            this.Color = color;
        }

        public void TurnOn() 
        {
            Console.WriteLine("Chiroq Yondi");
        }

        public void TurnOff() 
        {
            Console.WriteLine("Chiroq O`chdi");
        }
    }
}