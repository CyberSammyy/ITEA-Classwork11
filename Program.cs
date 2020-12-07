using System;

namespace ITEA_Classwork11
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points1 = new Point[4];
            points1[0] = new Point(0, 0);
            points1[1] = new Point(0, 2);
            points1[2] = new Point(4, 2);
            points1[3] = new Point(4, 0);
            Point[] points2 = new Point[3];
            points2[0] = new Point(0, 0);
            points2[1] = new Point(4, 4);
            points2[2] = new Point(8, 0);
            Figure figure1 = new Rectangle(points1);
            Figure figure2 = new Triangle(points2);
        }
    }
}
