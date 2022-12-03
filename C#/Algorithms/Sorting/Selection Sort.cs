using System;

namespace Sorting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { -4, 5, 9, -7, 1, 2, 1, -16, 16, 18, 4 };
            selectionSort(ref array);
            displayArray(ref array);
        }

        public static void selectionSort(ref int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                
                int minIndex = i;
                for (int j = i+1; j < length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                (array[minIndex], array[i]) = (array[i], array[minIndex]);
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