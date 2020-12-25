using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLessonTaskTwo
{
    class Message
    {
        private string _str;
        private static string[] separators = { ",", ".", "!", "?", ";", ":", " " };
        public Message (string message)
        {
            _str = message;
        }
        public Message() { }

        public string message
        {
            get
            {
                return _str;
            }
            set
            {
                _str = value;
            }
        }


        public void printWordsWithALimitOfLetters(int limitOfLetters, string youMessage)
        {
            var messageString = youMessage.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach(string str in messageString)
            {
                if(str.Length >= limitOfLetters)
                {
                    Console.Write($" {str}");
                }
            }
        }

        public void printWordsWithALimitOfLetters(int limitOfLetters)
        {
            var messageString = _str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in messageString)
            {
                if (str.Length >= limitOfLetters)
                {
                    Console.Write($" {str}");
                }
            }
        }

        public void DeleteWordsEndingWithTheSpecifiedCharacter(string Character, string message)
        {
            var messageString = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string strOut = string.Empty;
            foreach (string str in messageString)
            {
                if(str[str.Length - 1].ToString() == Character)
                {

                }
                else
                {
                    strOut += $" {str}";
                }
            }
            Console.WriteLine(strOut);
        }

        public void DeleteWordsEndingWithTheSpecifiedCharacter(string Character)
        {
            var messageString = _str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string strOut = string.Empty;
            foreach (string str in messageString)
            {
                if (str[str.Length - 1].ToString() == Character)
                {

                }
                else
                {
                    strOut += $" {str}";
                }
            }
            Console.WriteLine(strOut);
        }

        public void theLongestWord(string message)
        {
            var messageString = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string strOut = string.Empty;
            if (messageString.Length > 0)
            {
                strOut = messageString[0];
                foreach (string str in messageString)
                {
                    if(str.Length > strOut.Length)
                    {
                        strOut = str;
                    }
                }
            }
            Console.WriteLine($"Самое длинное слово в сообщение: {strOut}");
        }

        public void theLongestWord()
        {
            var messageString = _str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string strOut = string.Empty;
            if (messageString.Length > 0)
            {
                strOut = messageString[0];
                foreach (string str in messageString)
                {
                    if (str.Length > strOut.Length)
                    {
                        strOut = str;
                    }
                }
            }
            Console.WriteLine($"Самое длинное слово в сообщение: {strOut}");
        }

        //Я не понял, что от меня хотят в этом задани поэтому могу предполохить, что выполнил его не верно или не до конца(Задание: г)
        public void stringBuild()
        {
            var messageString = _str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string strOut = string.Empty;
            if (messageString.Length > 0)
            {
                strOut = messageString[0];
                foreach (string str in messageString)
                {
                    if (str.Length > strOut.Length)
                    {
                        strOut = str;
                    }
                }
            }
            StringBuilder stringBuilder = new StringBuilder(strOut);
            Console.WriteLine(stringBuilder);
        }

        public void stringBuild(string message)
        {
            var messageString = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string strOut = string.Empty;
            if (messageString.Length > 0)
            {
                strOut = messageString[0];
                foreach (string str in messageString)
                {
                    if (str.Length > strOut.Length)
                    {
                        strOut = str;
                    }
                }
            }
            StringBuilder stringBuilder = new StringBuilder(strOut);
            Console.WriteLine(stringBuilder);
        }

    }
}
