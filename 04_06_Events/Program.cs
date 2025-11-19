using System;

namespace _04_06_Events
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
        // we create an event as below called posted with a type of event
        // it needs to be static as well inorder to access it in our static main
        static public event Action Posted;
         static void Main(string[] args)
        {
            // we instantiate the stats class then we call the start function
            var stats = new Stats();
            stats.Start();

            var data = new Data();

            Console.WriteLine("What is your name?");
            data.Name = WriteTryAgain();

            Console.WriteLine("What is your age?");
            data.Age = int.Parse(WriteTryAgain());

            Console.WriteLine("What month were you born in?");
            data.Month = WriteTryAgain();

            // we trigger the event as soon as the user input their information
            Posted();

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
