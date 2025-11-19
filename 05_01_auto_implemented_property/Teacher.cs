using System;
using System.Collections.Generic;
using System.Text;

namespace _05_01_auto_implemented_property
{
     class Teacher : Member, IPayee
    { 
        public string Subject { get; set; }

        // implement interfaces pay function(the classes own version of it)
        public void Pay()
        {
            Console.WriteLine("Paying Teacher");  
        }
    }
}