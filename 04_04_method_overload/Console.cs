using System;
using System.Collections.Generic;
using System.Text;

// renaming your namespace avoids conflicts with other namespaces
namespace Util
{
    class Console
    {
        // creating the console function which will ask the questions
        static public string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        // we have overloaded the previous ask function with another ask function
        // this is ok as long as we have different parameters
        static public string Ask(int question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
        static public int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch (Exception)
            {
                //we provide a custom message as a parameter
                throw new FormatException("Input was not a number");
            }
        }
    }
}