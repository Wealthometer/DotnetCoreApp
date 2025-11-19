using System;

namespace _04_06_Events
{
    // this class will simulate the marketing or registering team binding to our event
    class Stats
    {
        public void Start()
        {
            // we will access the posted event
            // we register the hasPosted function to the register event
            Program.Posted += HasPosted;
        }

        //we need to specify a function in that will be executed when the event is triggered
        void HasPosted()
        {
            Console.WriteLine("Survey posted, run stats");
        }
    }
}