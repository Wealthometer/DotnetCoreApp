using System;
using System.Collections.Generic;

namespace _01_20_usings_collection_list
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // replace the array with a list with type string & int
            var studentNames = new List<string>(); 
            var studentGrades = new List<int>();

            var adding = true;

            //we use while loop to add an indefinite amount of students 
            // we will use a for loop that will count through the student count
            while(adding)
            {
                Console.Write("Student Name: ");
                studentNames.Add(Console.ReadLine());

                Console.Write("Student Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");

                if(Console.ReadLine() != "y")
                    adding = false;
            }

            // we access the student names through an index of the for loop
            // we access the student count through the .count method
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }   
            
        }
    }
}
