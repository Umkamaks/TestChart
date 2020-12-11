using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestChart
{
    public struct Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; }
        public double Y { get; }
    }
}
