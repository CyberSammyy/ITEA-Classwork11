using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace ITEA_Classwork11
{
    class Triangle : Figure
    {
        public List<double> Sides { get; set; }

        public Triangle(Point[] points)
        {
            base.points = points;
            if (points.Length == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i + 1 == 3)
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
            double p = 0;
            foreach(var side in Sides)
            {
                p += side;
            }
            p = p / 2;
            return Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }
        public override double GetSide(Point p1, Point p2)
        {
            return Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }
    }
}
