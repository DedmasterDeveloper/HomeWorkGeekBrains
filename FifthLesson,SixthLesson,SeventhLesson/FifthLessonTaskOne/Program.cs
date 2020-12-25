using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FifthLessonTaskOne
{
    /*
     * 1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
     * а) без использования регулярных выражений;
     * б) с использованием регулярных выражений.
    */

    class ChekLogin
    {
        char[] numbers = new char[] {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        char[] characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
        string _login = string.Empty;
        public ChekLogin() { }
        public ChekLogin(string login)
        {
            _login = login;
        }

        public string notRegChek()
        {
            bool chekCharacters = false;
            if(_login != string.Empty)
            {
                foreach(char number in numbers)
                {
                    if(_login[0] == number)
                    {
                        return "Логин не соответствует условию, первое значение цифра!";
                    }
                }
                foreach(char str in _login)
                {
                    chekCharacters = false;
                    foreach (char chr in characters)
                    {
                        if (chr == str)
                        {
                            chekCharacters = true;
                            break;
                        }
                            
                    }
                    if (!chekCharacters)
                        return "Логин не соответствует условию, логин содержит не допустимые символы";
                }
                return $"логин: {_login} соответствует всем условиям";
            }
            else
            {
                return "логин не может быть пустым!";
            }
        }
        public string notRegChek(string login)
        {
            bool chekCharacters = false;
            if (login != string.Empty)
            {
                foreach (char number in numbers)
                {
                    if (login[0] == number)
                    {
                        return "Логин не соответствует условию, первое значение цифра!";
                    }
                }
                foreach (char str in login)
                {
                    chekCharacters = false;
                    foreach (char chr in characters)
                    {
                        if (chr == str)
                        {
                            chekCharacters = true;
                            break;
                        }
                    }
                    if (!chekCharacters)
                        return "Логин не соответствует условию, логин содержит не допустимые символы";
                }
                return $"логин: {login} соответствует всем условиям";
            }
            else
            {
                return "логин не может быть пустым!";
            }
        }
        public string regChek()
        {
            Regex myReg = new Regex(@"[^a-zA-Z0-9]");
            Regex numbers = new Regex(@"[0-9]");
            if (_login != string.Empty)
            {
                if (numbers.IsMatch(_login[0].ToString()))
                    return "Логин не сооветствует условию, первый символ цыфра";
                else
                if (myReg.IsMatch(_login))
                    return "Логин не соответствует условию, логин содержит не допустимые символы";

            }
            else
                return "логин не может быть пустым!";

            return $"логин: {_login} соответствует всем условиям";


        }
        public string regChek(string login)
        {
            Regex myReg = new Regex(@"[^a-zA-Z0-9]");
            Regex numbers = new Regex(@"[0-9]");
            if (login != string.Empty)
            {
                if (numbers.IsMatch(login[0].ToString()))
                    return "Логин не сооветствует условию, первый символ цыфра";
                else
                if (myReg.IsMatch(login))
                    return "Логин не соответствует условию, логин содержит не допустимые символы";
            }
            else
                return "логин не может быть пустым!";

            return $"логин: {login} соответствует всем условиям";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ChekLogin";
            Console.Write("Введите ваш логин: ");
            string userLogin = Console.ReadLine();
            ChekLogin chekLogin = new ChekLogin(userLogin);
            Console.WriteLine(chekLogin.notRegChek());
            Console.WriteLine(chekLogin.regChek());
            Console.WriteLine("Для закрытия нажмите Enter");
            Console.Read();

        }
    }
}
