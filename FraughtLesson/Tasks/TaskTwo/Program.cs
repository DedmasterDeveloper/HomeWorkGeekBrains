using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Задание:
 * а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. 
 * Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов. 
 * В Main продемонстрировать работу класса.
 * б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 */

namespace TaskTwo
{
    class MyClass
    {
        int[] _a;
        public MyClass(int size, int startPoit, int step)
        {
            int[] array = new int[size];
            array[0] = startPoit;
            for(int i =1; i < array.Length; i++)
            {
                array[i] = array[i - 1] + step;
            }
            _a = array;
        }
        public MyClass(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + fileName);
                var str = reader.ReadLine();
                int.TryParse(str, out int len);

                _a = new int[len];

                for (int i = 0; i < len; i++)
                {
                    if (int.TryParse(reader.ReadLine(), out int num))
                    {
                        _a[i] = num;
                    }
                }

            }
            else
                throw new Exception("Файл не найден");
        }
        public int sum()
        {
            int rez = _a.Sum();
            return rez;
        }

        public int[] Inverse()
        {
            int[] rezArray = new int[_a.Length];
            for(int i = 0; i < _a.Length; i++)
            {
                rezArray[i] = _a[i] * -1;
            }
            return rezArray;
        }
        public int[] Multi (int a)
        {
            int[] rezArray = new int[_a.Length];
            for (int i = 0; i < _a.Length; i++)
            {
                rezArray[i] = _a[i] * a;
            }
            return rezArray;
        }
        public int MaxCount()
        {
            int max = _a.Max();
            int rez = 0;
            for (int i = 0; i < _a.Length; i++)
            {
                if(_a[i] == max)
                {
                    rez++;
                }
            }
            return rez;
        }

        public int[] returnArray()
        {
            return _a;
        }

        public MyClass(int[] a)
        {
            _a = a;
        }

        public int[] A
        {
            get { return _a; }
        }

        public int this[int i]
        {
            get
            {
                return _a[i];
            }
            set
            {
                _a[i] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyArray = new MyClass(10, 1, 4);
            int sumArray = MyArray.sum();
            int[] Inverse = MyArray.Inverse();
            int[] Multi = MyArray.Multi(5);
            int MaxCount = MyArray.MaxCount();
            Console.WriteLine($"Сумма всех эементов массива {string.Join(",", MyArray.A)} = {sumArray}, масив с заменёнными знаками: {string.Join(",", Inverse)}, метод Multi(5) возвращает: {string.Join(",", Multi)}, количество максимальных элементов в массиве: {MaxCount}");

            MyClass newArray = new MyClass("LoadArray.txt");
            int[] fileArray = newArray.returnArray();
            Console.WriteLine($"Новый массив из файла: {string.Join(",", fileArray)}");
            Console.ReadLine();
        }
    }
}
