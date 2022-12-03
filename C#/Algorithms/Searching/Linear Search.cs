using System;

namespace Searching
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 12, -3, 4, 5, -8, 20, 11 };

            int position;
            position = linearSearch(ref array, 4);
            if (position != -1)
                Console.WriteLine($"item found at index: {position}");
            else
                Console.WriteLine("item was not found");
            
            position = linearSearch(ref array, 100);
            if (position != -1)
                Console.WriteLine($"item found at index: {position}");
            else
                Console.WriteLine("item was not found");
        }

        public static int linearSearch(ref int[] array, int value)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}