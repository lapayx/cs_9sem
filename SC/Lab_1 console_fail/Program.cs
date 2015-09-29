using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_1_console_fail
{
    class Program
    {
        struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }


        static void Main(string[] args)
        {
        

            List<Point> src = new List<Point>();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            string line;
            StreamReader file = new StreamReader("text.txt");
            while ((line = file.ReadLine()) != null)
            {
                var k = line.Split(',');
                if (k.Length < 2)
                {
                    continue;
                }
                src.Add(new Point { X = double.Parse(k[0]), Y = double.Parse(k[1]) });
            }

            file.Close();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ru-RU");

            foreach (Point x in src)
            {
                Console.WriteLine("X: {0} Y: {1}", x.X, x.Y);
            }
            Console.ReadKey();
        }
    }
}
