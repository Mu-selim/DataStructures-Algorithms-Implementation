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
            Console.Write("Stack now: ");
            stack.displayStack();
            Console.WriteLine($"Number of Stack items: {stack.count()}");
            Console.WriteLine($"Stack peek: {stack.peek()}");
            Console.WriteLine($"Pop from Stack: {stack.pop()}");
            Console.Write("Stack now: ");
            stack.displayStack();
            Console.WriteLine($"Pop from Stack: {stack.pop()}");
            Console.WriteLine($"Stack peek: {stack.peek()}");
            Console.WriteLine($"Number of Stack items: {stack.count()}");
            Console.Write("Stack now: ");
            stack.displayStack();

        }
    }

    class Node
    {
        public int data;
        public Node link;
    }
    class Stack
    {
        private Node stackTop;
        private int counter;

        public Stack()
        {
            this.stackTop = null;
            counter = 0;
        }

        public bool isEmpty()
        {
            return stackTop == null;
        }

        public void push(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            newNode.link = stackTop;
            stackTop = newNode;

            counter++;
        }

        public int pop()
        {
            if (!isEmpty())
            {
                int temp = stackTop.data;
                stackTop = stackTop.link;
                counter--;
                return temp;
            }
            else
            {
                Console.WriteLine("Stack is EMPTY!");
                return -1;
            }
        }

        public int peek()
        {
            if (!isEmpty())
            {
                return stackTop.data;
            }
            else
            {
                Console.WriteLine("Stack is EMPTY!");
                return -1;
            }
        }

        public int count()
        {
            return counter;
        }

        public void displayStack()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is EMPTY!");
                return ;
            }

            Node tempNode = this.stackTop;
            while (tempNode != null)
            {
                int data = tempNode.data;
                tempNode = tempNode.link;
                if (tempNode != null)
                {
                    Console.Write($"{data} -> ");
                }
                else
                {
                    Console.Write($"{data}");
                }
            }
            Console.WriteLine();
        }
    }
}