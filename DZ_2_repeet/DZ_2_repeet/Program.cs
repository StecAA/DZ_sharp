using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_SHARP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string branching = default;
            Console.WriteLine("1. Написать метод, возвращающий минимальное из трёх чисел.");
            Console.WriteLine("2. Написать метод подсчета количества цифр числа.");
            Console.WriteLine("3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
            Console.WriteLine("4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). ");
            Console.WriteLine(" Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");
            Console.WriteLine("5. Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).");
            Console.WriteLine("ВВЕдите номер задания");
            branching = Console.ReadLine();

            switch (branching)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("1. Написать метод, возвращающий минимальное из трёх чисел.");
                    Console.WriteLine("Минимальное число : {0}", Convert.ToString(GetMinDigit()));
                    Console.ReadLine();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("2. Написать метод подсчета количества цифр числа.");
                    GetQuaDigit();
                    Console.ReadLine();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("3. С клавиатуры вводятся числа, пока не будет введен " +
                        "0. Подсчитать сумму всех нечетных положительных чисел.");
                    GetDigitSum();
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    int i = 0;
                    Console.WriteLine("4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль." +
                        " На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). ");
                    Console.WriteLine(" Используя метод проверки логина и пароля, написать программу:" +
                        " пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. " +
                        "С помощью цикла do while ограничить ввод пароля тремя попытками.");
                    string login = default;
                    string password = default;
                    do
                    {
                        Console.WriteLine("Введите логин");
                        login = Console.ReadLine(); ;
                        Console.WriteLine("Введите пароль");
                        password = Console.ReadLine();
                        if (GetPass(login, password) == true) break;// выходим из цикла если авторизация прошла. 
                        else
                        {
                            Console.WriteLine("Ввели неверно!");
                        }
                        i++;

                    }
                    while (i < 3);
                    Console.ReadLine();
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("5. Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).");
                    int a, b = default;
                    Console.WriteLine("Введите  a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите  b");
                    b = Convert.ToInt32(Console.ReadLine());
                    Recursive(a, b);
                    Console.ReadLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Введите целые положительные номера заданий!");
                    Console.ReadLine();
                    break;
            }
            int GetMinDigit() 
            {
                int buf = 0;
                int[] num = new int[3];
                for (int caunt = 0; caunt < 3; ++caunt)
                {
                    Console.WriteLine("Введите число");
                    num[caunt] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Число {0}: {1}", caunt + 1, num[caunt]);
                    if (caunt == 0)
                    {
                        buf = num[caunt];
                    }

                    if (num[caunt] < buf)
                    {
                        buf = num[caunt];
                    }
                }
                return buf;
            }
            void GetQuaDigit()
            {
                Console.WriteLine("Введите число  для подсчёта цифр");
                int digit = Convert.ToInt32(Console.ReadLine());
                int number = 1;
                int bufer = digit;
                while ((digit /= 10) != 0)
                {
                    ++number;
                }

                Console.WriteLine("Количетсво цифр  {0} числа : {1}  ", number, bufer);
            }

            void GetDigitSum()
            {
                int num = 0;
                int sum = 0;
                do
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num > 0)
                    {
                        if ((num % 2) > 0)
                        {
                            sum = sum + num;
                        }
                    }

                }
                while (num != 0);
                Console.WriteLine("Сумма всех нечётных положительный чисел  {0}  ", sum);

            }
            bool GetPass(string login, string password)
            {
                if ((login == "root") && (password == "GeekBrains"))
                {
                    Console.WriteLine("Вы ввели верный пароль , поздравляю!");
                    return true;

                }
                else
                {
                    return false;
                }

            }

            void Recursive(int a, int b)
            {
                Console.WriteLine(a);
                if (a != b)
                Recursive(++a, b);
            }

        }
    }
}