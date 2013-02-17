namespace SpecialValue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            int rowNum = int.Parse(Console.ReadLine());
            int[][] rows = new int[rowNum][];

            for (int i = 0; i < rowNum; i++)
            {
                string line = Console.ReadLine();
                string[] lineNum = line.Split(',');
                for (int k = 0; k < lineNum.Length; k++)
                {
                    lineNum[k].Trim();
                }

                rows[i] = new int[lineNum.Length];
                for (int j = 0; j < lineNum.Length; j++)
                {
                    rows[i][j] = int.Parse(lineNum[j]);
                }
            }

            int jumper = 0;
            int jumpCount = 1;
            int fir = 0;
            int specialValue = 0;
            for (int j = 0; j < rows[0].Length; j++)
            {
                jumper = rows[0][j];

                while (jumper >= 0)
                {
                    if (fir + 1 > rowNum - 1)
                    {
                        fir = -1;
                    }

                    fir++;
                    jumper = rows[fir][jumper];
                    jumpCount++;
                }

                fir = 0;
                int tmp = jumpCount + (jumper * (-1));

                if (specialValue < tmp)
                {
                    specialValue = tmp;
                }

                jumpCount = 1;
            }

            Console.WriteLine(specialValue);
        }
    }
}