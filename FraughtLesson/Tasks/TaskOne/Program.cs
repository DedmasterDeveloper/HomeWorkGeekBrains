using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    /*
     * Задание:
     * Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
     * В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20]{5,8,6,9,-3,-12,89,10,11,16,19,23,5,22,35,68,95,44,21,51};
            int count = 0;
            int answer = 0;
            foreach(int i in array)
            {
                if (i % 3 == 0)
                    count++;
                if(count == 2)
                {
                    answer++;
                    count = 0;
                }

            }
            Console.WriteLine($"Ответ: {answer}");
            Console.WriteLine("Для закрытия нажмите Enter");
            Console.ReadLine();
        }
    }
}
