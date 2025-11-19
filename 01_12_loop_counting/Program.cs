using System;

namespace _01_12_loop_counting
{
    class Program
    {
        static void Main(string[] args)
        {
            // use a for loop to repeat over the whole process like five times
            for (int x = 1; x <= 5; x++)
            {
                // use for loop to count from 1 to 10
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                // use another for loop to count from 10 back to 1
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
