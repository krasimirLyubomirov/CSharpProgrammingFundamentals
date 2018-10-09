using System;
using System.Collections.Generic;
using System.Text;

namespace IntersectionOfCircles
{
    class Circle
    {
        public Point Point { get; set; }
        public double Radius { get; set; }

        public Circle(Point point, double radius)
        {
            this.Point = point;
            this.Radius = radius;
        }

        public Circle() { }
    }
}
