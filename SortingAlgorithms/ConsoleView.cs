using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class ConsoleView
    {
        public static void Intro(String nameOfAlgorithm)
        {
            Console.WriteLine(nameOfAlgorithm);
            Console.WriteLine("Enter comma separated integers");
            Console.WriteLine("eg.  5,9,12,2,3,6,7788,7,10,11,1,8");
            Console.WriteLine("");
        }

        public static int[] GetIntArray()
        {
            String inputData = Console.ReadLine();
            String[] rawStringArray = inputData.Replace(" ", "").Split(',');
            return Array.ConvertAll(rawStringArray, s => int.Parse(s));
        }
        public static void PrintIntArray(int[] array)
        {
            Console.WriteLine("");
            Console.WriteLine("Result:");
            Console.WriteLine("[{0}]", string.Join(", ", array));
            Console.WriteLine("");
        }
        public static void End()
        {
            Console.WriteLine("Press any key to close this window . . .");
            Console.ReadKey();
        }
    }
}
