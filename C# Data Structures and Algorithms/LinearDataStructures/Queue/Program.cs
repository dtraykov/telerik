/* Implement the ADT queue as dynamic linked list. Use generics 
 * (LinkedQueue<T>) to allow storing different data types in the queue.
 */
namespace Queue
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var queue = new CustomQueue<int>();

            queue.Enqueue(1);
            Console.WriteLine(queue);

            queue.Enqueue(2);
            Console.WriteLine(queue);

            queue.Enqueue(3);
            Console.WriteLine(queue);

            Console.WriteLine("First: {0}", queue.Peek());

            Console.WriteLine("Count: {0}", queue.Count);
            Console.WriteLine("Contains 2: {0}", queue.Contains(2));

            while (queue.Count != 0)
            {
                Console.WriteLine("Dequeue: {0}", queue.Dequeue());
            }

            Console.WriteLine("Count: {0}", queue.Count);
        }
    }
}
