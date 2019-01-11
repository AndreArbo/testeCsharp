using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testesCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = string.Empty;
            while(menu != "out")
            {
                Console.WriteLine("Escolha o menu:");
                menu = Console.ReadLine();
                switch(menu)
                {
                    case "a":
                        string Sarray = Console.ReadLine();
                        int[] array = Sarray.Split(',').Select(Int32.Parse).ToArray();
                        long result = TotalAllEvenNumbers(array);
                        Console.WriteLine("Sumatorio dos numeros pares: " + result);
                        break;

                    case "out":
                        break;
                }
            } 
            

        }
        private static long TotalAllEvenNumbers(int[] intArray)
        {
            return intArray.Where(i => i % 2 == 0).Sum();//i => (long)i
        }
    }
}
