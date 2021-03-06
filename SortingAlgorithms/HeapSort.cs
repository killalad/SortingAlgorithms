﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class HeapSort
    {
        public static String Name = "HeapSort";
        private int[] array;
        public HeapSort(int[] rawArray) { array = rawArray; }

        // sort the array
        public int[] Sort()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                HeapMax(i);
                Swap(0, (array.Length - 1 - i));
            }
            return array;
        }

        //get the highest number in remaining unsorted part of array
        private void HeapMax(int state)
        {
            int lowestParentPosition = ((array.Length - 1 - state) / 2);
            for (int i = lowestParentPosition - 1; i >= 0; i--)
            {
                SortTriangle(i);
            }
        }

        // swap values
        private void Swap(int first, int second)
        {
            int temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        // sort the abstract heap triangle
        private void SortTriangle(int parentPosition)
        {
            int firstChildPosition = 2 * parentPosition + 1;
            int secondChildPosition = 2 * parentPosition + 2;

            if (firstChildPosition < array.Length && array[parentPosition] < array[firstChildPosition])
            {
                Swap(parentPosition, firstChildPosition);
            }
            if (secondChildPosition < array.Length && array[parentPosition] < array[secondChildPosition])
            {
                Swap(parentPosition, secondChildPosition);
            }
        }
    }
}
