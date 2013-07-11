/*
 * Implement a class PriorityQueue<T> based on the data structure "binary heap".
 */
namespace PriorityQueue
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            PriorityQueue<string> stringQueue = new PriorityQueue<string>();
            stringQueue.Enqueue("A");
            stringQueue.Enqueue("D");
            stringQueue.Enqueue("C");
            stringQueue.Enqueue("B");
            stringQueue.Enqueue("E");
            stringQueue.DisplayQueue();

            PriorityQueue<int> intQueue = new PriorityQueue<int>();
            intQueue.Enqueue(40);
            intQueue.Enqueue(70);
            intQueue.Enqueue(20);
            intQueue.Enqueue(60);
            intQueue.Enqueue(50);
            intQueue.Enqueue(100);
            intQueue.Enqueue(82);
            intQueue.Enqueue(35);
            intQueue.Enqueue(90);
            intQueue.Enqueue(10);
            intQueue.DisplayQueue();

            Console.WriteLine("Inserting a new node with value 120");
            intQueue.Enqueue(120);
            intQueue.DisplayQueue();

            Console.WriteLine("Removing max element");
            intQueue.Dequeue();
            intQueue.DisplayQueue();

            Console.WriteLine("Inserting a new node with value 5");
            intQueue.Enqueue(5);
            intQueue.DisplayQueue();
        }
    }
}
