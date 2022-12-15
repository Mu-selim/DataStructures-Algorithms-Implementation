using System;
using System.Collections.Generic;

namespace palindrome_expression
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("madam"));
            Console.WriteLine(IsPalindrome("ababab"));
            Console.WriteLine(IsPalindrome("Muhammad"));
            Console.WriteLine(IsPalindrome("a"));
            Console.WriteLine(IsPalindrome("ab"));
            Console.WriteLine(IsPalindrome("aaaaaaaaa"));
            Console.WriteLine(IsPalindrome("azaza"));
        }

        public static bool IsPalindrome(string expression)
        {
            int length = expression.Length, i = 0;
            Stack<char> stack = new Stack<char>();

            while (i < length/2) 
            {
                stack.Push(expression[i++]);
            }

            i = length % 2 == 0 ? i : i + 1;

            while (i < length)
            {
                if (stack.Pop() != expression[i++])
                {
                    return false;
                }
            }
            return true;
        }
    }
}