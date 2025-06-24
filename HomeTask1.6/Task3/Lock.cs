using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask16.Task3
{
    public class Lock : IDevice
    {
        public bool IsLocked { get; set; }
        public void TurnOn()
        {
            this.IsLocked = false;
            Console.WriteLine("Qulf ochild");
        }

        public void TurnOff()
        {
            this.IsLocked = true;
            Console.WriteLine("Qulf yopildi");
        }

        public void GetStatus() 
        {
            Console.WriteLine("Qulf hozir: " + this.IsLocked);
        }
    }
}