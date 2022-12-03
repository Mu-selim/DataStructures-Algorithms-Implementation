using System;

namespace Sorting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { -4, 5, 9, -7, 1, 2, 1, -16, 16, 18, 4 };
            insertionSort(ref array);
            displayArray(ref array);
        }

        public static void insertionSort(ref int[] array)
        {
            int length = array.Length;
            for (int i = 1; i < length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }

        }
        public static void displayArray(ref int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();
        }
    }
}