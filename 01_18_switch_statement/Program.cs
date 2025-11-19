using System;

namespace _01_18_switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Years of experience do you have?");

            // convert readline string to an int
            var years = int.Parse(Console.ReadLine());

            switch(years)
            {
                case 0:
                    Console.WriteLine("Inexperienced");
                    break;
                case 1:
                    Console.WriteLine("Junior");
                    break; 
                case 2:
                    Console.WriteLine("Intermediate");
                    break;
                case 3:
                    Console.WriteLine("Advanced");
                    break;
                default:
                    Console.WriteLine("Senior");
                    break;               
            }
            
        }
    }
}
