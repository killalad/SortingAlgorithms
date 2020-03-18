using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class HeapSortView
    {
        public static void intro()
        {
            Console.WriteLine("Enter comma separated integers");
            Console.WriteLine("eg.  5,9,12,2,3,6,7788,7,10,11,1,8");
            Console.WriteLine("");
        }
        public static void printArrayData(int[] array)
        {
            Console.WriteLine("");
            Console.WriteLine("Result:");
            Console.WriteLine("[{0}]", string.Join(", ", array));
            Console.WriteLine("");
            Console.WriteLine("Press any key to close this window . . .");
        }
    }
}
