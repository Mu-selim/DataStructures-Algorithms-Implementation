using System;
using System.Collections;

namespace QueueUsingStack
{
    class Program
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(12);
            queue.Enqueue(20);
            queue.Enqueue(-15);
            queue.Enqueue(7);
            queue.Enqueue(-5);
            Console.Write($"Queue Items: ");
            queue.displayQueue();
            Console.WriteLine($"Queue items Count: {queue.Count()}");
            Console.WriteLine($"Dequeued item: {queue.Dequeue()}");
            Console.WriteLine($"Dequeued item: {queue.Dequeue()}");
            Console.WriteLine($"Queue items Count: {queue.Count()}");
            Console.Write($"Queue Items: ");
            queue.displayQueue();
            Console.WriteLine("Enqueued item: 100");
            queue.Enqueue(100);
            Console.WriteLine($"Queue items Count: {queue.Count()}");
            Console.Write($"Queue Items: ");
            queue.displayQueue();
            
        }
    }

    class Queue
    {
        private Stack stack1 = new Stack();
        private Stack stack2 = new Stack();

        public void Enqueue(int value)
        {
            while (stack1.Count > 0)
            {
                // Move all stack1 items in stack2
                stack2.Push(stack1.Pop());
            }
            
            // add value to stack1
            stack1.Push(value);

            while (stack2.Count > 0)
            {
                /*
                 * Move all stack2 items back to stack1
                 * to make sure that the new value is at
                 * the bottom of the stack (acts as FIFO)
                 */
                stack1.Push(stack2.Pop());
            }
        }

        public int Dequeue()
        {
            if (stack1.Count != 0)
            {
                return (int)stack1.Pop();
            }
            else
            {
                Console.WriteLine("Queue is EMPTY!");
                return 0;
            }
        }

        public int Count()
        {
            return stack1.Count;
        }

        public bool isEmpty()
        {
            return Count() == 0;
        }

        public void displayQueue()
        {
            Stack tempStack = (Stack)stack1.Clone();
            while (tempStack.Count > 0)
            {
                Console.Write($"{tempStack.Pop()}  ");
            }
            Console.WriteLine();
        }
    }
}