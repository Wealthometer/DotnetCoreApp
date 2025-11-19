using System;

// PROBLEM: THE SCHOOL WANTS TO BE ABLE TO TRACK 10 STUDENTS INSIDE A CLASS & THEIR GRADES
// SOLUTION: 
namespace _01_19_final_student_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());

        
            var studentNames = new string[studentCount]; 
            var studentGrades = new int[studentCount]; 

            // we will use a for loop that will count through the student count
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student Name: ");
                studentNames[i] = Console.ReadLine();

                Console.WriteLine("Student Grade: ");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }   
            
        }
    }
}
