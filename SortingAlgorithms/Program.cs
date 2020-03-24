using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleView.Intro(HeapSort.Name);

            int[] rawArray = ConsoleView.GetIntArray();

            HeapSort heapSort = new HeapSort(rawArray);

            ConsoleView.PrintIntArray(heapSort.Sort());

            ConsoleView.End();
        }
    }
}
