using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask17.Formula
{
    public static class Rectangle
    {
        public static double CalcRectangleArea(double length, double width) 
        {
            return length * width;
        }
        public static double CalcRectanglePerimeter(double length, double width) 
        {
            return 2 * (length + width);
        }
    }
}