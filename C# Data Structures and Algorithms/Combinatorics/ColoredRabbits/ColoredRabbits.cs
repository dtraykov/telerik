namespace ColoredRabbits
{
    using System;
    using System.Collections.Generic;

    public class ColoredRabbits
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<long, long> rabits = new Dictionary<long, long>();

            for (int i = 0; i < count; i++)
            {
                long number = long.Parse(Console.ReadLine());
                number++;
                if (rabits.ContainsKey(number))
                {
                    rabits[number] += number;
                }
                else
                {
                    rabits.Add(number, number);
                }
            }

            long rabitCount = 0;
            foreach (var pair in rabits)
            {
                if (pair.Key == pair.Value)
                {
                    rabitCount += pair.Key;
                }
                else
                {
                    long tmpVal = pair.Value;
                    while (tmpVal > 0)
                    {
                        long tmp = pair.Key * pair.Key;
                        tmpVal -= tmp;
                        rabitCount += pair.Key;
                    }
                }
            }

            Console.WriteLine(rabitCount);
        }
    }
}