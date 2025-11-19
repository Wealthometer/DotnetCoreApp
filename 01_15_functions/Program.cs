using System;
 
namespace _01_13_school_tracker
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            if (name == "")
            {
                WriteTryAgain();
                name = Console.ReadLine();
            }

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            if (age == "")
            {
                WriteTryAgain();
                age = Console.ReadLine();
            }

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            if (month == "")
            {
                WriteTryAgain();
                month = Console.ReadLine();
            }

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            if(month == "march")
            {
                Console.WriteLine("you are an Aries.");
            }
            else if(month == "april")
            {
                Console.WriteLine("you are a Taurus.");
            }
            else if (month == "may")
            {
                Console.WriteLine("you are a Gemini.");
            }
        }

        // this is a function with no return type
        static void WriteTryAgain()
        {
            Console.WriteLine("You didn't type anything, please again?");
        }
    }
}
