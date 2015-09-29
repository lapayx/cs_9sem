using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительнео число для расчета квадратного корня методом Ньютона");
            Console.Write("Число: ");
            double src = double.Parse(Console.ReadLine());
            double res = 0.00005;
            double tres = 0.00005;
            double tich = 0.00001;
            do{ 
                res = tres;
                tres = (res + src/res)/2;
            } while(Math.Abs( res -tres)>tich);

            Console.WriteLine("Методом Ньютона:{0}",tres);
            Console.WriteLine("Библиотекой Math:{0}", Math.Sqrt(src));
            Console.ReadKey();
        }
    }
}
