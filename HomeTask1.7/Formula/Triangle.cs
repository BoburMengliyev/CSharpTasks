using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask17.Formula
{
    public static class Triangle
    {
        public static double CalcTriangleArea(double baseLength,double height) 
        {
            return 0.5 * baseLength * height;
        }

        public static double CalcTrianglePerimeter(double side1, double side2, double side3) 
        {
            return side1 + side2 + side3;
        }
    }
}