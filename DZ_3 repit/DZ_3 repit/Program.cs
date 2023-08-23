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

            public int _bufReal, _bufImaginary;

            public Complex(int real, int imaginary)
            {
                _bufReal = real;
                _bufImaginary = imaginary;
            }
            public override string ToString()
            {
                return _bufImaginary >= 0 ? $"{_bufReal} + {_bufImaginary}i" : $"{_bufReal} - {-_bufImaginary}i";
            }

            public static Complex operator -(Complex _bufComplexClassFerst, Complex _bufComplexClassSecond)
            {
                return new Complex(real: _bufComplexClassFerst._bufReal - _bufComplexClassSecond._bufReal,
                    imaginary: _bufComplexClassFerst._bufImaginary - _bufComplexClassSecond._bufImaginary);
            }
            public static Complex operator +(Complex _bufComplexClassFerst, Complex _bufComplexClassSecond)
            {
                return new Complex(real: _bufComplexClassFerst._bufReal + _bufComplexClassSecond._bufReal,
                    imaginary: _bufComplexClassFerst._bufImaginary + _bufComplexClassSecond._bufImaginary);
            }
            public static Complex operator *(Complex _bufComplexClassFerst, Complex _bufComplexClassSecond)
            {
                return new Complex(real: (_bufComplexClassSecond._bufReal * _bufComplexClassFerst._bufReal) +
                    (_bufComplexClassSecond._bufReal * _bufComplexClassFerst._bufImaginary),
                    imaginary: (_bufComplexClassSecond._bufImaginary * _bufComplexClassFerst._bufReal) +
                    (_bufComplexClassSecond._bufImaginary * _bufComplexClassFerst._bufImaginary));
            }
        }

        struct ComplexStr
        {
            public int _bufReal, _bufImaginary;

            public ComplexStr(int real, int imaginary)
            {
                _bufReal = real;
                _bufImaginary = imaginary;
            }
            public override string ToString()
            {
                return _bufImaginary >= 0 ? $"{_bufReal} + {_bufImaginary}i" : $"{_bufReal} - {-_bufImaginary}i";
            }

            public static ComplexStr operator -(ComplexStr _bufComplexStrFerst, ComplexStr _bufComplexStrSecond)
            {
                return new ComplexStr(real: _bufComplexStrFerst._bufReal - _bufComplexStrSecond._bufReal,
                    imaginary: _bufComplexStrFerst._bufImaginary - _bufComplexStrSecond._bufImaginary);
            }
            public static ComplexStr operator +(ComplexStr _bufComplexStrFerst, ComplexStr _bufComplexStrSecond)
            {
                return new ComplexStr(real: _bufComplexStrFerst._bufReal + _bufComplexStrSecond._bufReal,
                    imaginary: _bufComplexStrFerst._bufImaginary + _bufComplexStrSecond._bufImaginary);
            }

        }
        static void Main(string[] args)
        {
            int _bufReal, _bufImaginary;
            Console.WriteLine("1. \n  Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.");
            Console.WriteLine("2. \n  Добавить диалог с использованием switch демонстрирующий работу класса.");
            Console.WriteLine($"3. \n  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). \n Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.");
            Console.WriteLine("ВВедите номер задания . ");
            string z = Console.ReadLine();
            switch (z)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Введите вещественную часть комплексного числа ");
                    _bufReal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите Минимую часть комплексного числа ");
                    _bufImaginary = Convert.ToInt32(Console.ReadLine());
                    ComplexStr _complexDigitStrFerst = new ComplexStr(_bufReal, _bufImaginary);
                    Console.WriteLine(_complexDigitStrFerst);
                    Console.WriteLine("Введите вещественную часть второго комплексного числа ");
                    _bufReal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите Минимую часть  второго комплексного числа ");
                    _bufImaginary = Convert.ToInt32(Console.ReadLine());
                    ComplexStr _complexDigitStrSecond = new ComplexStr(_bufReal, _bufImaginary);
                    Console.WriteLine(_complexDigitStrSecond);
                    Console.WriteLine("Доманстрация работы структуры ниже \n ({0}) + ({1}) = {2}  \n ({0}) - ({1}) = {3} ", 
                       _complexDigitStrFerst , _complexDigitStrSecond, _complexDigitStrFerst + _complexDigitStrSecond,
                       _complexDigitStrFerst - _complexDigitStrSecond);
                    Console.ReadLine();


                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Введите вещественную часть комплексного числа ");
                    _bufReal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите Минимую часть комплексного числа ");
                    _bufImaginary = Convert.ToInt32(Console.ReadLine());
                    Complex _complexDigitFerst = new Complex(_bufReal, _bufImaginary);
                    Console.WriteLine(_complexDigitFerst);
                    Console.WriteLine("Введите вещественную часть второго комплексного числа ");
                    _bufReal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите Минимую часть  второго комплексного числа ");
                    _bufImaginary = Convert.ToInt32(Console.ReadLine());
                    Complex _complexDigitSecond = new Complex(_bufReal, _bufImaginary);
                    Console.WriteLine(_complexDigitSecond);
                    Console.WriteLine("Введите операцию с комплексными числами из предложеных - , + , *");
                    z = Console.ReadLine();
                    switch (z)
                    {
                        case "+":
                            Console.WriteLine("Сложение двух комплексных чисел \n  ({0}) + ({1}) = {2} ",
                                _complexDigitFerst , _complexDigitSecond, _complexDigitFerst + _complexDigitSecond);
                         
                            Console.ReadLine();
                            break;
                        case "-":
                            Console.WriteLine("Вычитание двух комплексных чисел \n  ({0}) - ({1}) = {2} ",
                                _complexDigitFerst, _complexDigitSecond, _complexDigitFerst - _complexDigitSecond);
                            Console.ReadLine();
                            break;
                        case "*":
                            Console.WriteLine("Произведение двух комплексных чисел \n  ({0}) * ({1}) = {2} ",
                                _complexDigitFerst, _complexDigitSecond, _complexDigitFerst * _complexDigitSecond);
                            Console.ReadLine();
                            break;


                    }
                    break;
                case "3":
                    Console.WriteLine("Введите число. Пока не буддет введён 0 ");
                    InDigitSum();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("ВВедите номер задания  верно. ");
                    break;

            }

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
                        if ((_digit > 0) && ((_digit % 2) != 0))
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