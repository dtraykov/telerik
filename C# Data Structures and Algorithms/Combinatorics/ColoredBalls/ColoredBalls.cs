namespace ColoredBalls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class ColoredBalls
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> letterCounter = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (letterCounter.ContainsKey(input[i]))
                {
                    letterCounter[input[i]]++;
                }
                else
                {
                    letterCounter.Add(input[i], 1);
                }
            }

            BigInteger dividend = 1;
            BigInteger divisor = 0;
            bool isFirst = true;
            foreach (var item in letterCounter)
            {
                if (isFirst)
                {
                    isFirst = false;
                    divisor = Factoriel(item.Value, input.Length);
                }
                else
                {
                    dividend *= Factoriel(1, item.Value);
                }
            }

            Console.WriteLine(divisor / dividend);
        }

        private static BigInteger Factoriel(int start, int end)
        {
            BigInteger result = 1;
            for (int i = start + 1; i <= end; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
