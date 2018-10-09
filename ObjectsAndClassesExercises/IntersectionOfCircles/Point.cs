using System;
using System.Collections.Generic;
using System.Text;

namespace IntersectionOfCircles
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Point() { }
    }
}
