using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using static ConsoleApp2.Program;


namespace ConsoleApp2
{
    //    1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
    //типа double (double, double). Продемонстрировать работу на функции с функцией a* x^2 и
    //функцией a* sin(x).
    //2. Модифицировать программу нахождения минимума функции так, чтобы можно было
    //передавать функцию в виде делегата.
    //а) Сделать меню с различными функциями и представить пользователю выбор, для какой
    //функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов,
    //в котором хранятся различные функции.

    // Дополнение задания из методичи. 
    //    Написать программу сохранения результатов вычисления заданной функции в файл для дальнейшей
    //обработки файла.Разбить программу на две функции: одна записывает данные функции в файла на
    //промежутке от a до b с шагом h, а другая считывает данные и находит минимум функции.



    class Program : SaveResultFun
    {
        public delegate double FunctionsMath(double minDigit, double maxDigit);
        public delegate double LinearMath(double digit);
        public delegate double LoadFile(string fileName);
        public delegate void SaveFile(string fileName, double minDigit, double maxDigit, double step, object deligate);
        public static double LinearEquation(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double QuadraticEquation(double a, double x)
        {
            return a * (x * x);
        }
        public static double SinEquation(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            LinearMath Linear = new LinearMath(LinearEquation);
            FunctionsMath Quadratic = new FunctionsMath(QuadraticEquation);
            FunctionsMath Sin = new FunctionsMath(SinEquation);
            LoadFile LoadFileFerst = new LoadFile(ConsoleApp2.LoadFile.Load);
            SaveFile SaveFileFerst = new SaveFile(SaveFunc);
            List<object> _ListeDelegate = new List<object>() { Linear, Quadratic, Sin, LoadFileFerst, SaveFileFerst };
            Console.WriteLine("Введите число a");
            double _minDigitX = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b, которое больше а ");
            double _maxDigitX = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг h ");
            double _step = double.Parse(Console.ReadLine());
            Console.WriteLine("Выбирите функцию для расчёта минимума и введите цифру \n " +
                "1) x * x - 50 * x + 10\n" +
                "2) a* x^2\n" +
                "3)a* sin(x )\n");
            string branching = Console.ReadLine();
            switch (branching)
            {
                case "1":
                    ((SaveFile)_ListeDelegate[4])("data.bin", _minDigitX, _maxDigitX, _step, _ListeDelegate[0]);
                    Console.WriteLine(" Минимальное значение результата вычесления функции {0}", ((LoadFile)_ListeDelegate[3])("data.bin"));
                    break;
                case "2":
                    ((SaveFile)_ListeDelegate[4])("data.bin", _minDigitX, _maxDigitX, _step, _ListeDelegate[1]);
                    Console.WriteLine(" Минимальное значение результата вычесления функции {0}", ((LoadFile)_ListeDelegate[3])("data.bin"));
                    break;
                case "3":
                    ((SaveFile)_ListeDelegate[4])("data.bin", _minDigitX, _maxDigitX, _step, _ListeDelegate[2]);
                    Console.WriteLine(" Минимальное значение результата вычесления функции {0}", ((LoadFile)_ListeDelegate[3])("data.bin"));
                    break;

            }
            Console.ReadKey();
        }
    }

}

