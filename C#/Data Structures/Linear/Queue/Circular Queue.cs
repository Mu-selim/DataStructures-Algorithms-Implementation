using System;

namespace QueueUsingArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            CircularQueue queue = new CircularQueue(10);
            Console.WriteLine("Size of Queue: " + queue.GetSize());
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(-30);
            queue.Enqueue(5);
            queue.Enqueue(-12);
            Console.WriteLine("Size of Queue: " + queue.GetSize());
            queue.displayQueue();
            queue.GetRear();
            queue.GetFront();
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(100);
            Console.WriteLine("Size of Queue: " + queue.GetSize());
            queue.displayQueue();
            queue.GetRear();
            queue.GetFront();
            queue.Clear();
            Console.WriteLine("Size of Queue: " + queue.GetSize());
        }
    }

    class CircularQueue
    {
        private int front, rear, capacity, count;
        private int[] queue;

        public CircularQueue(int capacity)
        {
            this.front = 0;
            this.rear = capacity-1; 
            this.capacity = capacity;
            this.queue = new int[capacity];
        }

        public Boolean IsEmpty()
        {
            return this.count == 0;
        }

        public Boolean IsFull()
        {
            return this.count == this.capacity;
        }

        public void Enqueue(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is Full.");
            }
            else
            {
                rear = (rear + 1) % capacity;
                queue[rear] = value;
                count++;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                int temp = queue[front];
                front = (front + 1) % capacity;
                count--;
                Console.WriteLine($"Dequeued items: {temp}");
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
                Console.WriteLine($"Queue front is {queue[front]}");
            }
        }

        public void GetRear()
        {
            Console.WriteLine($"Queue rear is {queue[rear]}");
        }

        public int GetSize()
        {
            return count;
        }

        public void Clear()
        {
            front = 0;
            rear = capacity-1;
            Array.Clear(this.queue, 0, this.capacity);
            count = 0;
        }

        public void displayQueue()
        {
            for (int i = front; i != (rear+1); i = (i+1)%capacity)
            {
                Console.Write($"{queue[i]}  ");
            }
            Console.WriteLine();
        }
    }
}