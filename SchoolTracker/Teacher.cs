using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
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