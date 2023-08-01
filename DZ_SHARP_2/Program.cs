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
            string z = default;
            Console.WriteLine("1. Написать метод, возвращающий минимальное из трёх чисел.");
            Console.WriteLine("2. Написать метод подсчета количества цифр числа.");
            Console.WriteLine("3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
            Console.WriteLine("4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). ");
            Console.WriteLine(" Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");
            Console.WriteLine("5. Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).");
            Console.WriteLine("ВВЕдите номер задания");
            z = Console.ReadLine();
            
            switch (z)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("1. Написать метод, возвращающий минимальное из трёх чисел.");
                    Console.WriteLine("Минимальное число : {0}",Convert.ToString(GetMinDigit()));
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
                    Console.WriteLine("3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
                    GetDigitSum();
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    int i = 0;
                    Console.WriteLine("4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). ");
                    Console.WriteLine(" Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");
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
                     b =  Convert.ToInt32(Console.ReadLine());
                    Recursive(a,b);
                    Console.ReadLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Введите целые положительные номера заданий!");
                    Console.ReadLine();
                    break;
            }
            int GetMinDigit() // Можно в одну строку уже готовым методом new int [] { 1, 2, 3 }.Max();
            {
                int a=0; // тут не понял почему надо присваивать значение при обявлении переменной 
                //, или ошибка компилятора CS0165 при этом программа выполняется .  Она же ниже инициализируется. 
                int[] num = new int[3];
                var rand = new Random();
                for (int i=0; i<3; i++)
                {
                    
                    num [i] = rand.Next(-100,101);
                    Console.WriteLine("Число {0}: {1}", i + 1, num[i]);
                    if (i == 0) 
                    {
                    a = num[i];
                    }
                    
                    if (num[i] < a) 
                    {
                        a = num[i];
                    }
                }
                return a;
            }
            void GetQuaDigit()
            {
                var rand = new Random();
                int digit = rand.Next(-100, 10);
                int number = digit < 0 ? 2 : 1;
                int bufer = digit;
                while ((digit /= 10) != 0)
                {
                    ++number; 
                }
                
                Console.WriteLine("Количетсво цифр  {0} числа : {1}  " , number, bufer);
            }

            void GetDigitSum()
            { int num = 0;
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
                Console.WriteLine("Сумма всех нечётных положительный чисел  {0}  ",sum);

            }
            bool GetPass(string login,string password)
            {
                if ((login == "root") & (password== "GeekBrains"))
                {
                    Console.WriteLine("Вы ввели верный пароль с чем вас и поздравляю!");
                    return true;
                    
                } 
                else
                {
                    return false;
                }  
                
            }

            int Recursive(int a, int b) 
            {
                Console.WriteLine(a);
                ++a;
                if (a == b)
                {
                    Console.WriteLine(a);
                    return a;
                }
                Recursive (a,b) ;
                return a;
            }

        }
    }
}
