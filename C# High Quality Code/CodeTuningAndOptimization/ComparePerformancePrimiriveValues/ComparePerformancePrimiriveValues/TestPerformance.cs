namespace ComparePerformancePrimiriveValues
{
    using System;
    using System.Diagnostics;

    public class TestPerformance
    {
        public static void Multiply(dynamic startValue, dynamic endValue, dynamic step)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (dynamic i = startValue; i <= endValue; )
            {
                i = i * step;
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void Substract(dynamic startValue, dynamic endValue)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (dynamic i = startValue; i > endValue; )
            {
                i--;
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void Add(dynamic startValue, dynamic endValue)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (dynamic i = startValue; i < endValue; )
            {
                i++;
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void Divide(dynamic startValue, dynamic endValue, dynamic step)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (dynamic i = startValue; i >= endValue; )
            {
                i = i / step;
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Add testing with decimal, double, float, int, long:");
            Console.WriteLine(new string('=', 50));
            Add(4m, 500000m);
            Add(4d, 500000d);
            Add(4f, 500000f);
            Add(4, 500000);
            Add(4L, 500000L);

            Console.WriteLine("Substract testing with decimal, double, float, int, long:");
            Console.WriteLine(new string('=', 50));
            Substract(500000m, 4m);
            Substract(500000d, 4d);
            Substract(500000f, 4f);
            Substract(500000, 4);
            Substract(500000L, 4L);

            Console.WriteLine("Multiply testing with decimal, double, float, int, long:");
            Console.WriteLine(new string('=', 50));
            Multiply(2m, 500000m, 2m);
            Multiply(2d, 500000d, 5d);
            Multiply(2f, 500000f, 5f);
            Multiply(2, 500000, 5);
            Multiply(2L, 500000L, 5L);

            Console.WriteLine("Divide testing with decimal, double, float, int, long:");
            Console.WriteLine(new string('=', 50));
            Divide(500000m, 4m, 2m);
            Divide(500000d, 4d, 2d);
            Divide(500000f, 4f, 2f);
            Divide(500000, 4, 2);
            Divide(500000L, 4L, 2L);
        }
    }
}
