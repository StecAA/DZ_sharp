using System;
using System.IO;

namespace DZ_4_ferst
{
    internal class ProgramBase
    {

        internal static int[] Tasks(int[] bufArr)
        {
            Random randRef = new Random();
            int counter = 0;
            int result = 0;
            while (counter != bufArr.Length)
            {
                bufArr[counter] = randRef.Next(-10000, 10000);
                Console.WriteLine(bufArr[counter]);
                if ((counter != 0) && ((bufArr[counter] % 3) == 0) ^ ((bufArr[counter - 1] % 3) == 0))
                {
                    ++result;
                    Console.WriteLine("\n  {0} пара {1} {2}", result, bufArr[counter], bufArr[counter - 1]);
                }
                ++counter;
            }
            Console.WriteLine(" Количество пар элементов массива,в которых только одно число делится на 3 --- {0}", result);
            Console.ReadLine();
            return bufArr;
        }
        internal static int[] ReadFile()
        {
            int counter = 0;
            int[] temp = new int[20]; // Можно сделать на списках , если размер не известен . Но списки ещё  не проходили.
            string path = "text1.txt";
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                temp[counter] = int.Parse(reader.ReadLine());
                ++counter;
            }

            return temp;
        }

    }
}