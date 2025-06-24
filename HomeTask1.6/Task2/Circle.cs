using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask16.Task2
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius, string color) : base(color)
        {
            this.radius = radius;
        }
    }
}