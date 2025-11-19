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
    }
}