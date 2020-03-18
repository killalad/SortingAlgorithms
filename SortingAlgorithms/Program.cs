using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            HeapSortView.intro();

            // get data
            String inputData = Console.ReadLine();

            // parse data
            String[] rawStringArray = inputData.Replace(" ", "").Split(',');
            int[] rawArray = Array.ConvertAll(rawStringArray, s => int.Parse(s));

            // sort data
            HeapSort heapSort = new HeapSort(rawArray);
            int[] sortedArray = heapSort.sort();

            // print data
            HeapSortView.printArrayData(sortedArray);

            Console.ReadKey();
        }
    }
}
