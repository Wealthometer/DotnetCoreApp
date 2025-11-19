using System;
using System.Collections.Generic;
using System.Text;

namespace _05_06_named_optional_arguments
{
    public class Logger
    {
        // we set the default system name here
        const string DefaultSystemName = "SchoolTracker";
        // we make use of an optional parameter as a default value
       public static void Log(string msg, string system = DefaultSystemName, int priority = 1)
       {
           Console.WriteLine("System: {0}, Priority: {1}, Msg: {2}", system, priority, msg);
       } 
    }
}