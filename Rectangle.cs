using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace ITEA_Classwork11
{
    class Rectangle : Figure
    {
        public List<double> Sides = new List<double>();
        public Rectangle(Point[] points)
        {
            base.points = points;
            if(points.Length == 4)
            {
                for(int i = 0; i < 4; i++)
                {
                    if(i + 1 == 4)
                    {
                        Sides.Add(GetSide(points[points.Length - 1], points[0]));
                        break;
                    }
                    Sides.Add(GetSide(points[i], points[i + 1]));
                }
                Area = GetArea();
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public override double GetArea()
        {
            return Sides[0] * Sides[1];
        }
        public override double GetSide(Point p1, Point p2)
        {
            return Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }
    }
}
