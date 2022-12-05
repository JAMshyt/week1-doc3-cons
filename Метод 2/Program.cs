using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод_2
{
    class Program
    {
        static double f(double x, out double y)
        {
            if ((x + 2) <= 1) y = x * x;
            else if (1 < (x + 2) & (x + 2) < 10) y = 1 / (x + 2);
            else y = x + 2;
            return y;
        }

        static double f(double x)
        {
            double y;
            if ((x + 2) <= 1) y = x * x;
            else if (1 < (x + 2) & (x + 2) < 10) y = 1 / (x + 2);
            else y = x + 2;
            return y;

        }
        static void Main(string[] args)
        {
            double a, b, h;
            do
            {
                try
                {
                    do
                    {
                        Console.Write("a=");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("b=");
                        b = double.Parse(Console.ReadLine());
                        Console.Write("h=");
                        h = double.Parse(Console.ReadLine());
                        if (a < b) break;
                        else Console.WriteLine("а Должно быть меньше б");

                    } while (true);

                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка, заново");
                }
            } while (true);
            for (double i = a; i <= b; i += h)
            {
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
            }

            Console.WriteLine("\n");

            for (double i = a; i <= b; i += h)
            {
                double y;
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i,out y));
            }
        }
    }
}
