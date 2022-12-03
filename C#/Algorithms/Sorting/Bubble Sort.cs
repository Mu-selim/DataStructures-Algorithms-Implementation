using System;

namespace Sorting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = { -4, 5, 9, -7, 1, 2, 1, -16, 16, 18, 4 };
            bubbleSort(ref array1);
            displayArray(ref array1);

            int[] array2 = { -4, 5, 9, -7, 1, 2, 1, -16, 16, 18, 4 };
            optimizedBubbleSort(ref array2);
            displayArray(ref array2);
        }

        public static void bubbleSort(ref int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length-1; i++)
            {
                for (int j = 0; j < length-i-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }
        
        public static void optimizedBubbleSort(ref int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length-1; i++)
            {
                bool hasSwap = false;
                for (int j = 0; j < length-i-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        hasSwap = true;
                    }
                }

                if (!hasSwap)
                {
                    break;
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