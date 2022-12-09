using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack_Applications
{
    class Program
    {
        public static void Main(string[] args)
        {
            Expression expression1 = new Expression("((3+4)*6+7/8)");
            Console.Write("((3+4)*6+7/8) to postfix: ");
            expression1.display();
            Console.WriteLine($"((3+4)*6+7/8) = {expression1.evalutaion()}");
            Expression expression2 = new Expression("(12 + (20 * 4 + 5) * 12^2 / 2)");
            Console.Write("(12 + (20 * 4 + 5) * 12^2 / 2) to postfix: ");
            expression2.display();
            Console.WriteLine($"(12 + (20 * 4 + 5) * 12^2 / 2) = {expression2.evalutaion()}");
        }
    }

    class Expression
    {
        private string exp;

        public Expression(string exp)
        {
            exp = String.Concat(exp.Where(c => !Char.IsWhiteSpace(c)));
            if (exp.Length != 0 && exp[0] != '(')
            {
                this.exp = "(" + exp + ")";
            }
            else
            {
                this.exp = exp;
            }
        }
        static bool arePair(char c1, char c2)
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
        
        static bool isBalanced(string s)
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

        static int precedence(char op)
        {
            switch (op)
            {
                case '(':
                case ')':
                    return 1;
                case '+':
                case '-':
                    return 2;
                case '*':
                case '/':
                    return 3;
                case '^':
                    return 4;
            }
            return -1;
        }

        static bool isOperator(string op)
        {
            return (new string[] {"+", "-", "*", "/", "^"}).Contains(op);
        }

        static ArrayList convertToPostfix(string exp)
        {
            int length = exp.Length;
            Stack stack = new Stack();
            ArrayList result = new ArrayList();

            for (int i = 0; i < length; i++)
            {
                StringBuilder number = new StringBuilder();
                bool isNumber = false;
                while (i < length && Char.IsDigit(exp[i]))
                {
                    number.Append(exp[i++]);
                    isNumber = true;
                }

                if (isNumber)
                {
                    result.Add(number.ToString());
                }

                if (exp[i] == ')')
                {
                    while (Convert.ToChar(stack.Peek()) != '(')
                    {
                        result.Add(stack.Pop());
                    }

                    stack.Pop();
                }
                else if (exp[i] == '(')
                {
                    stack.Push(exp[i]);
                }
                else
                {
                    while (stack.Count > 0 && precedence(exp[i]) <= precedence(Convert.ToChar(stack.Peek())))
                    {
                        result.Add(stack.Pop());
                    }
                    stack.Push(exp[i]);
                }
            }

            while (stack.Count > 0)
            {
                result.Add(stack.Pop());
            }
            return result;
        }

        double calculate(double n1, double n2, char op)
        {
            switch (op)
            {
                case '+':
                    return n1 + n2;
                case '-':
                    return n1 - n2;
                case '*':
                    return n1 * n2;
                case '/':
                    return n2 / n1;
                case '^':
                    return Math.Pow(n2, n1);
            }

            return -1;
        }

        public double evalutaion()
        {
            Stack<double> stack = new Stack<double>();

            ArrayList list = convertToPostfix(this.exp);
            for (int i = 0; i < list.Count; i++)
            {
                if (isOperator(Convert.ToString(list[i])))
                {
                    double n1 = stack.Pop();
                    double n2 = stack.Pop();
                    stack.Push(calculate(n1, n2, Convert.ToChar(list[i])));
                }
                else
                {
                    stack.Push(Convert.ToDouble(list[i]));
                }
            }
            return stack.Pop();
        }

        public void display()
        {
            ArrayList res = convertToPostfix(this.exp);
            for (int i = 0; i < res.Count; i++)
            {
                Console.Write($"{res[i]} ");
            }
            Console.WriteLine();
        }
    }
}