using System;
using System.Collections;
namespace Stack_Applications
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{}: "+ isBalanced("{}"));
            Console.WriteLine("{()}: " + isBalanced("{()}"));
            Console.WriteLine("{)}: "+ isBalanced("{)}"));
            Console.WriteLine("{(}): " + isBalanced("{(})"));
            Console.WriteLine("{(())()[()]}: "+ isBalanced("{(())()[()]}"));
            Console.WriteLine("{(())()[([{}])]}: "+ isBalanced("{(())()[([{}])]}"));
            Console.WriteLine("((12+5)*4): "+ isBalanced("((12+5)*4)"));
            Console.WriteLine("((12+5)*(4)): "+ isBalanced("((12+5)*(4))"));
            Console.WriteLine("((12+5)*(4): "+ isBalanced("((12+5)*(4)"));
            Console.WriteLine("((12+5)*(4)/12): "+ isBalanced("((12+5)*(4)/12)"));
        }

        public static bool arePair(char c1, char c2)
        {
            if ((c1 == '(' && c2 == ')') || (c1 == '[' && c2 == ']') || (c1 == '{' && c2 == '}'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isBalanced(string s)
        {
            Stack stack = new Stack();
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                char temp = s[i];
                if (temp == '(' || temp == '[' || temp == '{')
                {
                    stack.Push(temp);
                    continue;
                }

                if (temp == ')' || temp == ']' || temp == '}')
                {
                    if (stack.Count == 0 || !arePair(Convert.ToChar(stack.Pop()), temp))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}