namespace Salaries
{
    using System;

    public class Salaries
    {
        private static int countEmployees;
        private static long[] cache;
        private static bool[,] adjMatrix;

        public static long FindSalary(int employee)
        {
            if (cache[employee] > 0)
            {
                return cache[employee];
            }

            long salary = 0;
            for (int i = 0; i < countEmployees; i++)
            {
                if (adjMatrix[employee, i])
                {
                    salary += FindSalary(i);
                }
            }

            if (salary == 0)
            {
                salary = 1;
            }

            cache[employee] = salary;

            return salary;
        }

        public static void Main(string[] args)
        {
            countEmployees = int.Parse(Console.ReadLine());
            cache = new long[countEmployees];
            adjMatrix = new bool[countEmployees, countEmployees];

            for (int i = 0; i < countEmployees; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < countEmployees; j++)
                {
                    if (line[j] == 'Y')
                    {
                        adjMatrix[i, j] = true;
                    }
                }
            }

            long sumOfSalaries = 0;
            for (int i = 0; i < countEmployees; i++)
            {
                sumOfSalaries += FindSalary(i);
            }

            Console.WriteLine(sumOfSalaries);
        }
    }
}
