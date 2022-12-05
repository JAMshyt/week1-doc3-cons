using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы_1_К
{
    internal class Program
    {
        static void f(double x)
        {
            if (x % 5 == 0)
            {
                Console.WriteLine("Результат (кратное): " + x / 5);
            }
            else if ((x *10)%5 == 0)
            {
                Console.WriteLine("Результат (кратное): " + x / 5);
            }
            else
            {
                Console.WriteLine("Результат (не кратное):" + (++x));
            }
        }

        static void Main(string[] args)
        {
            double a;
            do
            {
                try
                {
                    Console.Write("Введите число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Еррор");
                }
            } while (true);
            f(a);
        }
    }
}
