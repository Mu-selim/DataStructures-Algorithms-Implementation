using System;

namespace Sorting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { -4, 5, 9, -7, 1, 2, 1, -16, 16, 18, 4 };
            shellSort(ref array);
            displayArray(ref array);
        }

        public static void shellSort(ref int[] array)
        {
            int length = array.Length;
            for (int gap = length/2; gap >= 1; gap /= 2)
            {
                int i = 0;
                for (int j = gap+i; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }

                    i++;
                }
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