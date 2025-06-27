using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask19
{
    public class Gauge
    {
        public int Value { get; set; }

        public Gauge()
        {
            this.Value = 0;
        }

        public void Increase() 
        {
            if (Value < 5) 
            {
                Value += 1;
            }
            Console.WriteLine(Value);
        }

        public void Decrease() 
        {
            if (Value > 0) 
            {
                Value -= 1;
            }
            Console.WriteLine(Value);
        }
        public bool Full() 
        {
            return Value == 5;
        }
    }
}
