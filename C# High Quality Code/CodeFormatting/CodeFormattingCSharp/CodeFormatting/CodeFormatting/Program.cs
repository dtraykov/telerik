namespace CodeFormatting
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (EventCommand.ExecuteNextCommand())
            {
            }

            Console.WriteLine(Messages.Output);
        }    
    }
}