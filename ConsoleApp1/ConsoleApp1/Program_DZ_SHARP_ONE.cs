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
        { //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
          //  а) используя склеивание;
          //  б) используя форматированный вывод;
          //  в) используя вывод со знаком $.
            Console.WriteLine("введите имя!");
            string name = Console.ReadLine();
            Console.WriteLine("введите фамилию!");
            string surname = Console.ReadLine();
            Console.WriteLine("введите возраст!");
            string age = Console.ReadLine();
            Console.WriteLine("введите рост!");
            string Height = Console.ReadLine();
            Console.WriteLine("введите вес!");
            string Weight = Console.ReadLine();
            string result_a = "ответ а конкатенация строк  " + name + " " + surname + " " + age + " " + Height + " " + Weight;
            Console.WriteLine(result_a);
            Console.WriteLine(" форматированный вывод {0} {1} {2} {3} {4}", name, surname, age, Height, Weight);
            Console.WriteLine($"ответ в инетрполяция строк {name} {surname} {age} {Height} {Weight}");
            Console.ReadLine();
            Console.Clear();
            // 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
            // I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
            Console.WriteLine("Введите рост в метрах!");
            Height = Console.ReadLine();
            Console.WriteLine("Введите вес!");
             Weight = Console.ReadLine();
            Double x, i ,z = default;
            x = Double.Parse(Height);
            i = Double.Parse(Weight);
            z = x * x;
            z = i / z;
            Console.WriteLine(" I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.");
            Console.WriteLine("ИМТ {0}", z);
            Console.ReadLine();
            Console.Clear();
            //3. Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
            //по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,
            //используя спецификатор формата .2f (с двумя знаками после запятой);
            Double x1, x2, y1, y2, r = default;
            x1 = 10;
            x2 = 11.2;
            y1 = 144;
            y2 = 150.2;
            r = Math.Sqrt(Math.Pow((x2 - x1), x2) + Math.Pow((y2 - y1), y2));
            Console.WriteLine("данные {0} {1} {2} {3}", x1,x2,y1,y2);
            Console.WriteLine("результат {0:F2}", r);
            Console.ReadLine();
            //test
        }
    }
}
