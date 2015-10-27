using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab_3_Evclid;

namespace Lab_3_consol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("НОД двух чисел по евклиду чисел 1365 и 9873");
            Console.WriteLine("{0}", Evclid.Calculate(1365, 9873));
            Console.WriteLine("НОД двух чисел по евклиду бинарному чисел 2136 и 3968");
            Console.WriteLine("{0}", Evclid.Calculate(2136, 3968));

            Console.ReadKey();

        }

    }
}
