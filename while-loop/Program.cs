using System;

namespace paascode
{
    class Program
    {
        static void Main(string[] args)
        {
            var passcode = "";

            //creating while loop
            while(passcode != "secret")
            {
                Console.WriteLine("what is your password?");
                passcode = Console.ReadLine();

                if(passcode != "secret")
                {
                    Console.WriteLine("Unauthorized Access");
                }
            }
            // end of while loop
            Console.WriteLine("You Have Been Authenticated");
            
        }
    }
}
