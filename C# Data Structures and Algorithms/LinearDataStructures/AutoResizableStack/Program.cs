/* Implement the ADT stack as auto-resizable array. Resize the capacity on demand 
 * (when no space is available to add / insert a new element).
*/

namespace AutoResizableStack
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var stack = new CustomStack<int>();

            stack.Push(1);
            Console.WriteLine(stack);

            stack.Push(2);
            Console.WriteLine(stack);

            stack.Push(3);
            Console.WriteLine(stack);

            Console.WriteLine("Last: {0}", stack.Peek());

            Console.WriteLine("Count: {0}", stack.Count);
            Console.WriteLine("Contains 2: {0}", stack.Contains(2));

            Console.WriteLine("Capacity: {0}", stack.Capacity);
            stack.TrimExcess();
            Console.WriteLine("Capacity: {0}", stack.Capacity);

            while (stack.Count != 0)
            {
                Console.WriteLine("Pop: {0}", stack.Pop());
            }

            Console.WriteLine("Count: {0}", stack.Count);
        }
    }
}
