using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLessonTaskThree
{
    /*
     * Переделать программу «Пример использования коллекций» для решения следующих задач:
     * а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
     * б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
     * в) отсортировать список по возрасту студента;
     * г) *отсортировать список по курсу и возрасту студента;
     * д) разработать единый метод подсчета количества студентов по различным параметрам выбора с помощью делегата и методов предикатов.
     */
    class Program
    {
        
        static void Main(string[] args)
        {
            readStudent student = new readStudent($"{AppDomain.CurrentDomain.BaseDirectory}Student.txt");
            List<string> Students = student.getStudent();
            FilterStudent filterStudent = new FilterStudent(Students);
            List<int> lvl = new List<int> { 5, 6 };
            List<string> filterOutStudents =  filterStudent.lvlFilter(lvl);
            Console.WriteLine($"Колличество студентов 5 и 6 курса: {filterOutStudents.Count}");
            Console.Read();
        }
    }
}
