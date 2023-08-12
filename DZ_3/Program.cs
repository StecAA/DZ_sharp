
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DZ_3
{
    internal class Program
    {


        public class Complex
        {

            public int a, b;
            public Complex(int re, int im)
            {
                a = re;
                b = im;
            }
            public override string ToString()
            {
                return b >= 0 ? $"{a} + {b}i" : $"{a} - {-b}i";
            }

            public static Complex operator -(Complex x, Complex y)
            {
                return new Complex(re: x.a - y.a, im: x.b - y.b);
            }
            public static Complex operator +(Complex x, Complex y)
            {
                return new Complex(re: x.a + y.a, im: x.b + y.b);
            }
            public static Complex operator *(Complex x, Complex y)
            {
                return new Complex(re: (y.a * x.a) + (y.a * x.b), im: (y.b * x.a) + (y.b * x.b));
            }
        }

        struct ComplexStr
        {
            public int a, b;

            public ComplexStr(int re, int im)
            {
                a = re;
                b = im;
            }
            public override string ToString()
            {
                return b >= 0 ? $"{a} + {b}i" : $"{a} - {-b}i";
            }

            public static ComplexStr operator -(ComplexStr x, ComplexStr y)
            {
                return new ComplexStr(re: x.a - y.a, im: x.b - y.b);
            }
            public static ComplexStr operator +(ComplexStr x, ComplexStr y)
            {
                return new ComplexStr(re: x.a + y.a, im: x.b + y.b);
            }

        }







        static void Main(string[] args)
        {

            Console.WriteLine("1. \n  Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.");
            Console.WriteLine("2. \n Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.");
            Console.WriteLine("3. \n  Добавить диалог с использованием switch демонстрирующий работу класса.");
            Console.WriteLine($"4. \n  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). \n Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.");
            Console.WriteLine("ВВедите номер задания . ");
            string z = Console.ReadLine();
            switch (z)
            {
                case "1":
                    ComplexStr z1 = new ComplexStr(re: 5, im: 88);
                    Console.WriteLine(z1);
                    ComplexStr z2 = new ComplexStr(re: 10, im: 1);
                    Console.WriteLine(z2);
                    ComplexStr z3 = z1 + z2;
                    Console.WriteLine(z3);
                    ComplexStr z4 = z1 - z2;
                    Console.WriteLine(z4);
                    Console.ReadLine();
                    break;
                case "2":
                    Complex z6 = new Complex(re: 1, im: 33);
                    Console.WriteLine(z6);
                    Complex z7 = new Complex(re: 33, im: 13);
                    Console.WriteLine(z7);
                    Complex z8 = z6 + z7;
                    Console.WriteLine(z8);
                    Complex z9 = z6 - z7;
                    Console.WriteLine(z9);
                    Complex z10 = z6 * z7;
                    Console.WriteLine(z10);
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    Complex z11 = new Complex(re: 1, im: 33);
                    Console.WriteLine(z11);
                    Complex z12 = new Complex(re: 33, im: 13);
                    Console.WriteLine(z12);
                    Console.WriteLine("3. \n  Добавить диалог с использованием switch демонстрирующий работу класса.");
                    Console.WriteLine("Введите операцию с комплексными числами из предложеных - , + , *");
                     z = Console.ReadLine();
                    switch (z)
                    { 
                    case "-":
                            Complex z13 = z11 - z12;
                            Console.WriteLine(z13);
                            Console.ReadLine();
                            break;
                    case "+":
                            Complex z14 = z11 + z12;
                            Console.WriteLine(z14);
                            Console.ReadLine();
                            break;
                    case "*":
                            Complex z15 = z11 * z12;
                            Console.WriteLine(z15);
                            Console.ReadLine();
                            break;


                    }
                    break;
                case "4":
                    Console.WriteLine("Введите число. Пока не буддет введён 0 ");
                    InDigitSum();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("ВВедите номер задания  верно. ");
                    break;

            }



            // не смог подключить класс из отдельного файла. Добавил в этот же класс. 
            // Class2.Complex z5 = new Class2.Complex( re: 1,  im: 33);
            // Class1.Complex z5 = new Class1.Complex(re: 1, im: 33);


            //   Console.WriteLine(z5);

            void InDigitSum()
            {
                string input = default;
                int sum = 0;
                do
                {
                    input = Console.ReadLine();
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    int _digit = default;
                    if (Int32.TryParse(input, out _digit))
                    {
                        Console.WriteLine(_digit);
                        if ((_digit > 0) & ((_digit % 2) != 0)) 
                        {
                            sum += _digit;
                         
                        }  // зачем TryParse к суме применять из условий задачи не понял.
                    }
                    else { Console.WriteLine("Преобразование завершилось неудачно"); }

                }
                while (input != "0");
                Console.WriteLine("Сумма нечетных положительны чисел {0}", sum);
                Console.ReadLine();
            }

        }
    }
}
