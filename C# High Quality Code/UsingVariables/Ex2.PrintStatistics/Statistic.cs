namespace Ex2.PrintStatistics
{
    using System;

    public class Statistic
    {
        public static void Main(string[] args)
        {
        }

        public void PrintStatistics(double[] numbers)
        {
            Console.WriteLine(this.FindMaxNumber(numbers));
            Console.WriteLine(this.FindMinNumber(numbers));
            Console.WriteLine(this.FindAvarage(numbers));
        }

        private double FindAvarage(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = sum / numbers.Length;
            return average;
        }

        private double FindMinNumber(double[] numbers)
        {
            double minNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            return minNumber;
        }

        private double FindMaxNumber(double[] numbers)
        {
            double maxNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }
    }
}
