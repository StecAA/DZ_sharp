using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_ferst
{
    internal class Program : ProgramBase
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Урок 4. Массивы. Текстовые файлы\r\n" +
                "1. Дан целочисленный массив из 20 элементов." +
                " Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.\n" +
                " Заполнить случайными числами. Написать программу,\n позволяющую найти и вывести количество пар элементов массива," +
                " в которых только одно число делится на 3." +
                " В данной задаче под парой подразумевается два подряд идущих элемента массива.\r\n" +
                "Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.\n" +
                "2. Реализуйте задачу 1 в виде статического класса StaticClass;\r\n" +
                "а) Класс должен содержать статический метод, который принимает на вход массив" +
                " и решает задачу 1;\r\nб) Добавьте статический метод для считывания массива из текстового файла." +
                " Метод должен возвращать массив целых чисел;");

            Random randRef = new Random();
            string branching = Console.ReadLine();
            int[] integerArray = new int[20];
            int counter = 0;

            while (counter != integerArray.Length)
            {
                integerArray[counter] = randRef.Next(-10000, 10000);
                Console.WriteLine(integerArray[counter]);
                counter++;
            }
            Tasks(integerArray);
            Console.WriteLine("2 задача. Вывод файла text1.txt из дериктории Debag");
            ReadFile();
            Console.ReadLine();
        }
    }
}
