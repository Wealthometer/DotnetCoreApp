using System;

// PROBLEM: THE SCHOOL WANTS TO BE ABLE TO TRACK 10 STUDENTS INSIDE A CLASS & THEIR GRADES
// SOLUTION: 
namespace _01_13_school_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // we store the student grades in an array
            // var studentGrades = new int[10];

            // alternative way of declaring an array
            // var studentGrades = new int[10] { 80, 77, 45, 87, 53, 43, 67, 24, 86, 98 };
               var studentGrades = new int[] { 80, 77, 45, 87, 53, 43, 67, 24, 86, 98, 40 }; 

            // we access the array values throuh indexing
            // studentGrades[0] = 80;
            // studentGrades[1] = 80;
            // studentGrades[9] = 80;

            Console.WriteLine(studentGrades[4]);
        }
    }
}
