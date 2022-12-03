using System;

namespace Searching
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 12, -3, 1, 1, 4, 5, -8, 20, 11 };
            Array.Sort(array);

            int position;
            position = binarySearch(ref array, 4);
            if (position != -1)
                Console.WriteLine($"item found at index: {position}");
            else
                Console.WriteLine("item was not found");
            
            position = binarySearch(ref array, 100);
            if (position != -1)
                Console.WriteLine($"item found at index: {position}");
            else
                Console.WriteLine("item was not found");
        }

        public static int binarySearch(ref int[] array, int value)
        {
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == value)
                {
                    return mid;
                }
                else if (array[mid] > value)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}