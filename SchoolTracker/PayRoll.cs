using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    interface IPayee
    {
        void Pay();
    }
    class PayRoll
    {
        // Teacher teacher1 = new Teacher();
        // Teacher teacher2 = new Teacher();
        // Principal principal = new Principal();

        
        // we create a list of payees of type IPayee
        // this way we have one list that we can add all the different types of payees to
        // then we can add any class that uses the IPayee Interface
        
        List<IPayee> payees = new List<IPayee>();

        // we create a quick constructor
        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }

        public void PayAll()
        {
            // teacher1.Pay();
           // teacher2.Pay();
           // principal.Pay(); 

           // we create a foreach loop that will iterate through the different payees inside our IPayee collection
            foreach (var payee in payees)
            {
                // we call it payee.pay
                payee.Pay();
            }            
           
        }   
    }
}