namespace Ex1.PrintBool
{
    using System;

    public class Boolean
    {
        public const int MaxCount = 6;

        public static void Main(string[] args)
        {
            ConsolePrint gg = new ConsolePrint();
            gg.PrintBoolean(true);
        }

        public class ConsolePrint
        {
            public void PrintBoolean(bool boolean)
            {
                string boolToString = boolean.ToString();
                Console.WriteLine(boolToString);
            }
        }
    }
}
