using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask15.IVehicle
{
    public class Car :IVehicle
    {
        private int gas;
        public Car(int gas) 
        {
            this.gas = gas;
        }

        public void Drive() 
        {
            if (gas > 0)
            {
                Console.WriteLine("Driving");
            }
            else 
            {
                Console.WriteLine("No Driving");
            }
        }

        public bool Refuel(int amount) 
        {
            gas += amount;
            return true;
        }
    }
}
