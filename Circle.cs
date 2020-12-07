using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace ITEA_Classwork11
{
    class Circle : Figure, IRoundable
    {
        public double Radius { get; set; }
        public Point Center { get; set; }
        public Circle(Point[] points)
        {
            base.points = points;
            if(points.Length == 2)
            {
                Center = points[0];
                Radius = GetSide(points[0], points[1]);
            }
            Area = GetArea();
        }
        public override double GetArea()
        {
            return PI * Radius * Radius;
        }
        public override double GetSide(Point p1, Point p2)
        {
            return Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }
    }
}
