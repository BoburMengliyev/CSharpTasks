using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18
{
    public class Counter
    {
        private int value;

        public Counter(int value)
        {
            this.value = value;
        }

        public void Decrement() 
        {
            if (value > 0) 
            {
                value--;
            }
        }

        public void Reset() 
        {
            value = 0;
        }

        public int PrintValue() 
        {
            return value;
        }
    }
}