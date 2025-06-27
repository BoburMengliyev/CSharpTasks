using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask19
{
    public class Counter
    {
        public int Value { get; set; }

        public Counter(int value)
        {
            this.Value = value;
        }
        public Counter() { this.Value = 0; }

        public void Increase() { this.Value += 1; }
        public void Decrease() { this.Value -= 1; }
        public void Increase(int increaseBy) 
        {
            if (increaseBy >= 0) 
            {
                this.Value += increaseBy; 
            }
        }
        public void Decrease(int decreaseBy)
        {
            if (decreaseBy >= 0) 
            {
                this.Value -= decreaseBy; 
            }
        }
    }
}
