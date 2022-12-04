using System;

namespace StackImplementation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            
            stack.push(4);
            stack.push(2);
            stack.push(5);
            stack.push(7);
            stack.push(-1);
            stack.displayStack();

            Console.WriteLine(stack.count());
            Console.WriteLine(stack.peek());
            Console.WriteLine(stack.pop());
            stack.displayStack();
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.peek());
            Console.WriteLine(stack.count());
            stack.displayStack();

        }
    }

    class Stack
    {
        private readonly int MAX = 1000;
        private int[] stack;
        private int top;

        public Stack()
        {
            stack = new int[MAX];
            top = -1;
        }

        public bool isFull()
        {
            return top >= MAX ? true : false;
        }

        public bool isEpmty()
        {
            return top < 0 ? true : false;
        }

        public void push(int value)
        {
            if (!isFull())
            {
                top++;
                stack[top] = value;
            }
            else
            {
                Console.WriteLine("Stack is FULL! -__-");
            }
        }

        public int pop()
        {
            if (!isEpmty())
            {
                return stack[top--];
            }
            else
            {
                Console.WriteLine("Stack is exactly EMPTY! -__-");
                return 0;
            }
        }

        public int peek()
        {
            if (!isEpmty())
            {
                return stack[top];
            }
            else
            {
                Console.WriteLine("Stack is EMPTY! -__-");
                return 0;
            }
        }

        public int count()
        {
            return (top + 1);
        }

        public void displayStack()
        {
            for (int i = 0; i < top; i++)
            {
                Console.Write($"{stack[i]} -> ");
            }
            Console.WriteLine($"{stack[top]}");
        }
    }
}