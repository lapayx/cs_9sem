using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число для конвертации в двоичный код");
            Console.Write("Целое число: ");
            int src = int.Parse(Console.ReadLine());
            string res = "";

            while (src > 0)
            {
                res = src % 2 + res;
                src = src / 2;
            }


            Console.WriteLine("Двоичное представление числа: {0}",res);
            Console.ReadKey();

        }
    }
}
