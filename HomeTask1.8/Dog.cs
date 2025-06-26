using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18
{
    public class Dog
    {
        private string name;
        private string breed;
        private int age;

        public Dog(string name, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }

        public string GetName() => name;
        public string GetBreed() => breed;
        public int GetAge() => age;
    }
}