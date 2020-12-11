using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestChart
{
    class Program
    {
        static void Main(string[] args)
        {


            var chartList = new List<Point> {
        //new Point(1, 1), // x = 50, y = 31
        //new Point(2, 2),
        //new Point(3, 3),
        //new Point(4, 4),
        //new Point(5, 5),
        //new Point(6, 6)
    };
            var chartList2 = new List<Point>();

            for (double i = 0; i < 20; i=i+0.1)
            {
                double y = Math.Cos(double.Parse(i.ToString()));

                Point point = new Point(i,y);
                chartList.Add(point);
            }
            for (double i = 0; i < 20; i = i + 0.1)
            {
                double y = Math.Acos(double.Parse(i.ToString()));

                Point point = new Point(i, y);
                chartList2.Add(point);
            }

            ConsoleChartDraw.DrawChart(chartList);
            ConsoleChartDraw.DrawChart(chartList2);
            Console.ReadKey();
        }
    }
}
