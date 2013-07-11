namespace ZigZag
{
    using System;

    public class ZigZag
    {
        private static int n;
        private static int k;
        private static bool[] used;
        private static int seqCount;

        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var inputs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(inputs[0]);
            int k = int.Parse(inputs[1]);

            int result = Solve(n, k);
            Console.WriteLine(result);
        }

        private static void PutBigger(int index, int current)
        {
            if (index == k)
            {
                seqCount++;
                return;
            }

            if (current == n - 1)
            {
                return;
            }

            for (int i = current + 1; i < n; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    PutSmaller(index + 1, i);
                    used[i] = false;
                }
            }
        }

        private static void PutSmaller(int index, int current)
        {
            if (index == k)
            {
                seqCount++;
                return;
            }

            if (current == 0)
            {
                return;
            }

            for (int i = current - 1; i >= 0; i--)
            {
                if (!used[i])
                {
                    used[i] = true;
                    PutBigger(index + 1, i);
                    used[i] = false;
                }
            }
        }

        private static int Solve(int testN, int testK)
        {
            n = testN;
            k = testK;

            seqCount = 0;
            used = new bool[n];
            PutBigger(0, -1);

            return seqCount;
        }
    }
}
