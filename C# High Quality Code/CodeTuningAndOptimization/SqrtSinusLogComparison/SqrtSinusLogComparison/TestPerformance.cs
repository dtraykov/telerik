using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrtSinusLogComparison
{
    class TestPerformance
    {
        public static void CalculateSin(dynamic startValue, dynamic endValue, dynamic step)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (dynamic i = startValue; i <= endValue; i = i + step)
            {
                Math.Sin(i);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void CalculateSqrt(dynamic startValue, dynamic endValue, dynamic step)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (dynamic i = startValue; i <= endValue; i = i + step)
            {
                Math.Sqrt(i);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void CalculateLog(dynamic startValue, dynamic endValue, dynamic step)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (dynamic i = startValue; i <= endValue; i = i + step)
            {
                Math.Log(i);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        static void Main(string[] args)
        {
           CalculateSqrt(2d, 10000d, 0.02d);
           CalculateSqrt(2f, 10000f, 0.02f);

           CalculateLog(2d, 10000d, 0.02d);
           CalculateLog(2f, 10000f, 0.02f);

           CalculateSin(2d, 10000d, 0.02d);
           CalculateSin(2f, 10000f, 0.02f);
        }
    }
}
