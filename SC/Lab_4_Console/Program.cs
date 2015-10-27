using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab_4_triangle;

namespace Lab_4_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Трегульник со сторонами 10 5 11:");
            var t = new Triangle(10, 5, 11);
            Console.WriteLine("Существует: {0}",t.isExists());
            Console.WriteLine("Имеет периметр: {0}",t.Perim());
            Console.WriteLine("Имеет площадь: {0}",t.Squere());

            Console.WriteLine("Трегульник со сторонами 10 5 5:");
            var z = new Triangle(10, 5, 5);
            Console.WriteLine("Существует: {0}", z.isExists());


            Console.ReadKey();
        }
    }
}
