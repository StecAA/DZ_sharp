using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя!");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию!");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите возраст!");
            string Age = Console.ReadLine();
            Console.WriteLine("Введите рост!");
            string Height = Console.ReadLine();
            Console.WriteLine("Введите вес!");
            string Weight = Console.ReadLine();
            string Result_a = "Ответ А Конкатенация строк  " + Name + " " + Surname + " " + Age + " " + Height + " " + Weight;
            Console.WriteLine(Result_a);
            Console.WriteLine(" форматированный вывод {0} {1} {2} {3} {4}", Name, Surname, Age, Height, Weight);
            Console.WriteLine($"Ответ В Инетрполяция строк {Name} {Surname} {Age} {Height} {Weight}");
            Console.ReadLine();
        }
    }
}
