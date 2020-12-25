using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLessonTaskOne
{
    /*
     * Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
     * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
     */

    delegate double DoOperation(double x, double y);

    class Program
    {
        public static void Process(DoOperation operation, double x, double y)
        {
            var res = operation(x, y);
            Console.Write($" = {res}");
            Console.WriteLine();
        }

        public static double Plus(double x, double y)
        {
            Console.Write($"{x} + {y}");
            return x + y;
        }

        public static double Minus(double x, double y)
        {
            Console.Write($"{x} - {y}");
            return x - y;
        }

        public static double MultiplicationDegree(double x, double y)
        {
            Console.Write($"{x} * {y}^2");
            return x * Math.Pow(y, 2);
        }

        public static double MultiplicationSin(double x, double y)
        {
            Console.Write($"{x} * sin({y})");
            return x * Math.Sin(y);
        }

        static void Main(string[] args)
        {
            Process(Plus, 10, 5);
            Process(Minus, 7, 13);

            DoOperation multiOperation = delegate (double x, double y)
            {
                Console.Write($"{x} * {y}");
                return x * y;
            };
            Process(MultiplicationDegree, 8, 3);
            Process(MultiplicationSin, 5, 9);

            Console.WriteLine($" = {multiOperation(5, 5)}");
            Console.WriteLine();

            Console.WriteLine("Для закрытия нажмите Enter");

            Console.ReadKey();
        }
    }
}
