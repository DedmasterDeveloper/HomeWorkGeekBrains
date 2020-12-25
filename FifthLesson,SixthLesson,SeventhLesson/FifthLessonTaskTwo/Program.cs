using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLessonTaskTwo
{
    /*
     * Разработать класс Message, содержащий следующие статические методы для обработки текста:
     * а) Вывести только те слова сообщения, которые содержат не более n букв.
     * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
     * в) Найти самое длинное слово сообщения.
     * г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
     * Продемонстрируйте работу программы на текстовом файле с вашей программой.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Message";
            Console.WriteLine("Введите ваше сообщение:");
            Message message = new Message(Console.ReadLine());
            message.printWordsWithALimitOfLetters(5);
            message.DeleteWordsEndingWithTheSpecifiedCharacter("т");
            message.theLongestWord();
            message.stringBuild();
            Console.WriteLine("Для закрытия нажмите Enter");
            Console.Read();
        }
    }
}
