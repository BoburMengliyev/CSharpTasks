using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13.Animal
{
    abstract class Animal
    {
        protected string name;

        public void SetName(string name) 
        {
            this.name = name;
        }

        public string GetName() 
        {
            return name;
        }

        public abstract void Eat();
    }
}
