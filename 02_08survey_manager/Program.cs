using System;

namespace _02_08survey_manager
{
    class Data
    {
       public string Name;
       public int Age;
       public string Month;

       public void Display()
       {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", Month);

            if(Month == "march")
            {
                Console.WriteLine("you are an Aries.");
            }
            else if(Month == "april")
            {
                Console.WriteLine("you are a Taurus.");
            }
            else if (Month == "may")
            {
                Console.WriteLine("you are a Gemini.");
            }
       }   
    }

    class Program
    {
         static void Main(string[] args)
        {
            var data = new Data();

            Console.WriteLine("What is your name?");
            data.Name = WriteTryAgain();

            Console.WriteLine("What is your age?");
            data.Age = int.Parse(WriteTryAgain());

            Console.WriteLine("What month were you born in?");
            data.Month = WriteTryAgain();

            // using function from the class above to output the details
            data.Display();


            
        }

        // this is a function with a return type of string
        //when a function returns then a function ends
        static string WriteTryAgain()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't type anything, please again?");
                return Console.ReadLine();
            }
            return answer;
        }
 
    }
}
