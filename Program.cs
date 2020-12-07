using System;

namespace ITEA_Classwork11
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[4];
            points[0] = new Point(0, 0);
            points[1] = new Point(0, 2);
            points[2] = new Point(4, 2);
            points[3] = new Point(4, 0);
            Figure figure = new Rectangle(points);
        }
    }
}
