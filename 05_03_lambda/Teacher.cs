using System;
using System.Collections.Generic;
using System.Text;

namespace _05_03_lambda
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