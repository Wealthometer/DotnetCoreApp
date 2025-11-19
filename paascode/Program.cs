using System;

namespace paascode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your password?");
            var paascode = Console.ReadLine();

            if(paascode == "secret")
            {
                Console.WriteLine("you have been authenticated");
            }
        }
    }
}
