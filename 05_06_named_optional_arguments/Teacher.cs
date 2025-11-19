using System;
using System.Collections.Generic;
using System.Text;

namespace _05_06_named_optional_arguments
{
     class Teacher : Member, IPayee
    { 
        public string Subject;

        // implement interfaces pay function(the classes own version of it)
        public void Pay()
        {
            Console.WriteLine("Paying Teacher");  
        }
    }
}