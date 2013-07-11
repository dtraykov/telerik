namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Side lengths must be positive.");
            }

            if (a + b < c || a + c < b || b + c < a)
            {
                throw new ArgumentException(
                   "A triangle cannot be constructed from three line segments " +
                   "if any of them is longer than the sum of the other two.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static string ConvertDigitToText(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentOutOfRangeException("The value must be in range [0...9].");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Array is null.");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("Array is empty.");
            }

            int maxValue = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxValue)
                {
                    maxValue = elements[i];
                }
            }

            return maxValue;
        }

        public static void PrintAsFloatNumber(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void PrintAsPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintRightAlignedNumber(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static bool CheckIsVertical(double x1, double x2)
        {
            bool isVertical = x1 == x2;

            return isVertical;
        }
        
        public static bool CheckIsHorizontal(double y1, double y2)
        {
            bool isHorizontal = y1 == y2;

            return isHorizontal;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 4));

            Console.WriteLine(ConvertDigitToText(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsFloatNumber(1.3);
            PrintAsPercent(0.75);
            PrintRightAlignedNumber(2.30);

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));

            bool isHorizontal = CheckIsHorizontal(-1, 2.5);
            Console.WriteLine("Horizontal? " + isHorizontal);

            bool isVertical = CheckIsVertical(3, 3);
            Console.WriteLine("Vertical? " + isVertical);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "From Sofia");
            Student stella = new Student(
                "Stella", 
                "Markova", 
                new DateTime(1993, 11, 03), 
                "From Vidin, gamer, high results");

            Console.WriteLine(
                "{0} is older than {1} -> {2}",
                peter.FirstName, 
                stella.FirstName, 
                peter.IsOlderThan(stella));
        }
    }
}
