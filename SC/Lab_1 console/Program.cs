using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_1_console
{
    class Program
    {
        struct Point {
            public double X{get;set;}
            public double Y { get; set; }
        }

        static void Main(string[] args)
        {
            List<Point> src = new List<Point>();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            string t;
            while (true) {
                t = Console.ReadLine();
                var k = t.Split(',');
                if (k.Length < 2) {
                    break;
                }
                src.Add(new Point { X = double.Parse(k[0]), Y = double.Parse(k[1]) });
            }

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ru-RU");

            foreach (Point x in src) {
                Console.WriteLine("X: {0} Y: {1}", x.X, x.Y);
            }
            Console.ReadKey();

        }
    }
}
