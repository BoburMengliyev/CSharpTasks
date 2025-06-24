using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask16.Task2
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width, string color) : base(color)
        {
            this.length = length;
            this.width = width;
        }
    }
}