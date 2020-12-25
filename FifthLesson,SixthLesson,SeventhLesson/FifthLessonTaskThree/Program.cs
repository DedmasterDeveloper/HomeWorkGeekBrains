using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLessonTaskThree
{
    /*
     * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
     * а) с использованием методов C#;
     * б) *разработав собственный алгоритм.
     * Например:
     * badc являются перестановкой abcd.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "badc";
            string s2 = "abcd";

            if(s1.Select(Char.ToLower).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToLower).OrderBy(x => x)))
            {
                Console.WriteLine($"Строка {s1} является перестановкой строки {s2}");
            }
            else
            {
                Console.WriteLine($"Строка {s1} не является перестановкой строки {s2}");
            }
            Console.WriteLine("Для закрытия нажмите Enter");
            Console.Read();
        }
    }
}
