using System;
using System.IO;

namespace DZ_4_ferst
{
    internal class ProgramBase
    {

        internal static void Tasks(int[] bufArr)
        {
            int counter = 0;
            int result = 0;
            while (counter != bufArr.Length)
            {
                if ((counter != 0) && ((bufArr[counter] % 3) == 0) != ((bufArr[counter - 1] % 3) == 0))
                {
                    ++result;
                    Console.WriteLine("\n  {0} пара {1} {2}", result, bufArr[counter], bufArr[counter - 1]);
                }
                ++counter;
            }
            Console.WriteLine(" Количество пар элементов массива,в которых только одно число делится на 3 --- {0}", result);
            Console.ReadLine();
        }
        internal static int[] ReadFile()
        {
            int counter = 0;
            int[] temp = new int[20]; // Можно сделать на списках , если размер не известен . Но списки ещё  не проходили.
            string path = "text.txt";
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            while (!reader.EndOfStream)
            {
                temp[counter] = int.Parse(reader.ReadLine());
                ++counter;
            }
            Array.ForEach(temp, Console.WriteLine);
            Tasks(temp);
            return temp;
        }

    }
}
