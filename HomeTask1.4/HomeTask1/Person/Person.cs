using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask14.HomeTask1.Person
{
    public class Person
    {
        private string name;
        private string address;

        public Person(string name,string address) 
        {
            this.name = name;
            this.address = address;
        }

        public string getName() 
        {
            return name;
        }

        public string getAddress() 
        {
            return address;
        }

        public void setAddress(string address) 
        { 
            this.address = address;
        }

        public string toString() 
        {
            return $"{name}({address})";
        }
    }
}
