using System;
 
namespace _01_13_school_tracker
{
    class Program
    {
        // the benefit of using an array is being able to iterate through its values using a loop
        static void Main(string[] args)
        {
         
               var studentGrades = new int[] { 80, 77, 45, 87, 53, 43, 67, 24, 86, 98, 40 }; 

                //we output studentgrade inside our student grades array
                foreach( var studentGrade in studentGrades)
                {
                    Console.WriteLine(studentGrade);
                }

            Console.WriteLine(studentGrades[4]);
        }
    }
}
