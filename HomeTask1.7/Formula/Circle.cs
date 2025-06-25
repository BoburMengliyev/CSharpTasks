using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask17.Formula
{
    public static class Circle
    {
        public static double CalcCircleArea(double radius) 
        {
            return Math.PI * radius * radius;
        }
        public static double CalcCirclePerimeter(double radius) 
        {
            return 2 * Math.PI * radius;
        }
    }
}