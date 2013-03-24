using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5.BitArray64
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BitArray64 firstNum = new BitArray64(4534543);
            BitArray64 secoundNum = new BitArray64(54545454545);

            Console.WriteLine("Test ToString()");
            Console.WriteLine(firstNum.ToString());

            foreach (var bit in firstNum)
            {
                Console.Write(bit);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Is First Num Equal to Secound Num");
            Console.WriteLine(firstNum.Equals(secoundNum));
            Console.WriteLine();

            Console.WriteLine("Isn't First Num Equal to Secound Num");
            Console.WriteLine(firstNum != secoundNum);
            Console.WriteLine();

            Console.WriteLine("GetHashCode()");
            Console.WriteLine(firstNum.GetHashCode());
            Console.WriteLine(secoundNum.GetHashCode());
        }
    }
}
