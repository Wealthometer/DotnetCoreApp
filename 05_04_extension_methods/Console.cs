using System;
using System.Collections.Generic;
using System.Text;

// renaming your namespace avoids conflicts with other namespaces
namespace Util
{
    public static class ExtensionMethods
    {
        // we extend the string type list of functions to include a toInt method
        // we use the parameter to specify what type were going to extend 
        // this is a keyword which is a reference variable that points to itself or its own object
        // this keyword is required inorder to have an extension method
        public static int toInt(this string value)
        {
            return int.Parse(value);
        }
    }
    class Console
    {
        // creating the console function which will ask the questions
       static public string Ask(string question)
       {
           System.Console.Write(question);
           return System.Console.ReadLine();   
       }
       static public int AskInt(string question)
       {
           try
           {
               System.Console.Write(question);
               // refactoring te readline
               return System.Console.ReadLine().toInt();
           }
           catch (Exception)
           {
               //we provide a custom message as a parameter
               throw new FormatException("Input was not a number");
           }
       } 
    }
}