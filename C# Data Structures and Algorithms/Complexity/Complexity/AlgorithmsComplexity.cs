namespace Complexity
{
    using System;

    public class AlgorithmsComplexity
    {
        /*
         * 1. What is the expected running time of the following C# code? Explain why. Assume the array's size is n.
         * 
         *  O(n^2)
         *  for цикъла ще се изпълни n на брой пъти, а условието на while цикъла ще стане false след n пъти,
         *  защото на всяка итерация се изпълнява или start++, или end--
         */
        public static long Compute(int[] arr)
        {
            long count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int start = 0, end = arr.Length - 1;
                while (start < end)
                {
                    if (arr[start] < arr[end])
                    {
                        start++;
                        count++;
                    }
                    else
                    {
                        end--;
                    }
                }
            }

            return count;
        }

        /*
         * 2. What is the expected running time of the following C# code? Explain why.
         * 
         * Първия for цикъл, ще се изпълни n пъти. 2 рия ще се изпълни толкова пъти колкото нечетни клетки има в колона 0
         * Best case: няма нито една нечетна клетка в колона 0 и алгоритъмът е линеен О(n)
         * Average case: половината са четни О(n*(m/2)) 
         * Worst case: всички са нечетни О(n*m)
         * 
         */
        public static long CalcCount(int[,] matrix)
        {
            long count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, 0] % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] > 0)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        /*
         * 3. * What is the expected running time of the following C# code? Explain why.
         * 
         * for цикъла се завърта при всяко рекурсивно извикване.
         * най вероятно има грешка и в кода, разменени са местата на GetLength(1) и GetLength(0)
         * О(n*m)
         */
        public static long CalcSum(int[,] matrix, int row)
        {
            long sum = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sum += matrix[row, col];
            }

            if (row + 1 < matrix.GetLength(0))
            {
                sum += CalcSum(matrix, row + 1);
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            // int[,] matrix = new int[3, 4]
            // {
            //    {1, 2, 3, 4},
            //    {5, 6, 7, 8},
            //    {9, 10, 11, 12},
            // };

            int[,] matrix = new int[3, 2]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 },
            };

            Console.WriteLine(CalcSum(matrix, 0));
        }
    }
}
