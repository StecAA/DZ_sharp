using System;
using System.IO;
using static ConsoleApp2.Program;

namespace ConsoleApp2
{
    internal class SaveResultFun
    {
        public static void SaveFunc(string fileName, double minDigit, double maxDigit, double step, object deligateFunc)
        {

            FileStream _fileBufer = new FileStream(fileName, FileMode.Create,
            FileAccess.Write);
            BinaryWriter _binWrite = new BinaryWriter(_fileBufer);
            double counter = minDigit;
            if ((Convert.ToString(deligateFunc.GetType()) != "ConsoleApp2.Program+LinearMath"))
            {
                Console.WriteLine("Введите деипазон для числа а \nВведите число a");
                double _minDigitX = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число b, которое больше а ");
                double _maxDigitX = double.Parse(Console.ReadLine());
                Console.WriteLine();
                double _counterSecond = _minDigitX;
                while (counter <= maxDigit)
                {
                    _binWrite.Write(((FunctionsMath)deligateFunc)(counter, _counterSecond));
                    Console.WriteLine(((FunctionsMath)deligateFunc)(counter, _counterSecond));
                    while (_counterSecond <= _maxDigitX)
                    {
                        _binWrite.Write(((FunctionsMath)deligateFunc)(counter, _counterSecond));
                        Console.WriteLine(((FunctionsMath)deligateFunc)(counter, _counterSecond));
                        ++_counterSecond;
                    }
                    counter += step;
                }


            }

            else
            {
                while (counter <= maxDigit)
                {
                    _binWrite.Write(((LinearMath)deligateFunc)(counter));
                    Console.WriteLine(((LinearMath)deligateFunc)(counter));
                    counter += step;
                }
            }
            _binWrite.Close();
            _fileBufer.Close();

        }
    }
}