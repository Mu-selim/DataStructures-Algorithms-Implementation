using System;

namespace QueueUsingArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinearQueue queue = new LinearQueue(10);
            Console.WriteLine("Size of Queue: " + queue.GetSize());
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(-30);
            queue.Enqueue(5);
            Console.WriteLine("Size of Queue: " + queue.GetSize());
            queue.GetRear();
            queue.GetFront();
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine("Size of Queue: " + queue.GetSize());
            queue.GetRear();
            queue.GetFront();
            queue.Clear();
            Console.WriteLine("Size of Queue: " + queue.GetSize());
        }
    }

    class LinearQueue
    {
        private int front;
        private int rear;
        private int capacity;
        private int[] queue;

        public LinearQueue(int capacity)
        {
            this.front = this.rear = -1;
            this.capacity = capacity;
            this.queue = new int[capacity];
        }

        public Boolean IsEmpty()
        {
            return this.rear < 0;
        }

        public Boolean IsFull()
        {
            return this.rear >= this.capacity-1;
        }

        public void Enqueue(int value)
        {
            if (this.IsFull())
            {
                Console.WriteLine("Queue is Full");
            }
            else
            {
                queue[++this.rear] = value;
            }
        }

        public void Dequeue()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                for (int i = 0; i <= this.rear; i++)
                {
                    queue[i] = queue[i + 1];
                }
                queue[rear --] = 0;
            }
        }

        public void GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine($"Queue front is {queue[0]}");
            }
        }

        public void GetRear()
        {
            Console.WriteLine($"Queue rear is {queue[rear]}");
        }

        public int GetSize()
        {
            return this.rear + 1;
        }

        public void Clear()
        {
            this.rear = this.front = -1;
            Array.Clear(this.queue, 0, this.capacity);
        }
    }
}