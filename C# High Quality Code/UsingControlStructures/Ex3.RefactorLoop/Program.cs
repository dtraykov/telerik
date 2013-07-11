namespace Ex3.RefactorLoop
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[100];
            bool expectedValueFound = false;
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine(numbers[index]);

                if (index % 10 == 0)
                {
                    if (numbers[index] == expectedValueFound)
                    {
                        expectedValueFound = true;
                        break;
                    }
                }
            }

            // More code here
            if (expectedValueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
