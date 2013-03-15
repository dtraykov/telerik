/* 7.Using delegates write a class Timer that has can execute certain method at each t seconds.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07.TimerDelegate
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Timer timer = new Timer(2000, 20);
            timer.CurrentMethods = PrintMessage;
            timer.Execute();
        }

        public static void PrintMessage()
        {
            Console.WriteLine("I am timer delegate and print myself at some interval.");
        }
    }
}
