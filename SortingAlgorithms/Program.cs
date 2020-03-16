using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter comma separated integers");
            Console.WriteLine("eg.  5,9,12,2,3,6,7788,7,10,11,1,8");
            Console.WriteLine("");

            // get data
            String inputData = Console.ReadLine();

            // parse data
            inputData = inputData.Replace(" ", "");
            String[] rawStringArray = inputData.Split(',');
            int[] rawArray = Array.ConvertAll(rawStringArray, s => int.Parse(s));

            // sort data
            HeapSort heapSort = new HeapSort(rawArray);
            int[] sortedArray = heapSort.sort();

            // print data
            Console.WriteLine("");
            Console.WriteLine("Result:");
            Console.WriteLine("[{0}]", string.Join(", ", sortedArray));
            Console.WriteLine("");
            Console.WriteLine("Press any key to close this window . . .");
            Console.ReadKey();
        }
    }
}
