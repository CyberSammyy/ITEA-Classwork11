using System;
using System.Collections.Generic;
using System.Text;

namespace ITEA_Classwork11
{
    public abstract class Figure
    {
        public double Area { get; set; }
        public Point[] points;
        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
        public virtual double GetSide(Point p1, Point p2)
        {
            throw new NotImplementedException();
        }

    }
}
