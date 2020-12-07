using System;
using System.Collections.Generic;
using System.Text;

namespace ITEA_Classwork11
{
    public class Point : Figure
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
