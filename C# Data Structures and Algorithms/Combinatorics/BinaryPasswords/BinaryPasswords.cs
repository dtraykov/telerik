namespace BinaryPasswords
{
    using System;
    using System.Numerics;

    public class BinaryPasswords
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    count++;
                }
            }

            BigInteger result = 1;
            for (int i = 0; i < count; i++)
            {
                result *= 2;
            }

            Console.WriteLine(result);
        }
    }
}