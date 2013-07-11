/* Write a program that reads a sequence of integers (List<int>) ending with an empty 
 * line and sorts them in an increasing order.
*/
namespace ListSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static List<int> ReadInput()
        {
            List<int> sequence = new List<int>();
            bool isValidNumber = true;

            while (isValidNumber)
            {
                string inputLine = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    isValidNumber = false;
                }
                else
                {
                    int number = int.Parse(inputLine);
                    sequence.Add(number);
                }
            }

            return sequence;
        }

        public static void Main(string[] args)
        {
            List<int> sequence = ReadInput();
            QuickSort(sequence, 0, sequence.Count - 1);

            foreach (var item in sequence)
            {
                Console.Write("{0} ", item);
            }
        }

        private static void QuickSort(List<int> array, int left, int right)
        {
            int pivot = 0;

            if (left < right)
            {
                pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
        }

        private static int Partition(List<int> array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }

        private static void Swap(List<int> array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
