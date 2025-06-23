using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask15.Animal
{
    abstract class Animal
    {
        public string name { get; set; }

        public void SetName(string name) 
        {
            this.name = name;
        }
        public string GetName() => name;
        public abstract void Eat();
    }
}
