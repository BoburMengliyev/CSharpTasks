using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask15.IVehicle
{
    interface IVehicle
    {
        void Drive();
        bool Refuel(int benzin);
    }
}
