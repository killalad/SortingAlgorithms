using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleView.intro();
            int[] rawArray = ConsoleView.getData();

            HeapSort heapSort = new HeapSort(rawArray);
            int[] sortedArray = heapSort.sort();

            ConsoleView.printArrayData(sortedArray);
            ConsoleView.end();
        }
    }
}
