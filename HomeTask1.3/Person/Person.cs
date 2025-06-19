using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13.Person
{
    internal class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public override string ToString() 
        {
            return $"Name: {Name}";
        }
    }
}
