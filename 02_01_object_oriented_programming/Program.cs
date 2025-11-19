using System;
using System.Collections.Generic;

namespace _02_01_object_oriented_programming
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // we a student list and we make of type student
            var students = new List<Student>();

            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            var adding = true;

            while(adding)
            {
                // we create a new object instance of type student
                var newStudent = new Student();

                Console.Write("Student Name: ");
                newStudent.Name = (Console.ReadLine());

                Console.Write("Student Grade: ");
                newStudent.Grade = (int.Parse(Console.ReadLine()));

                Console.Write("Student Birthday: ");
                newStudent.Birthday = (Console.ReadLine());

                Console.Write("Student Address: ");
                newStudent.Address = (Console.ReadLine());

                Console.Write("Student Phone Number: ");
                newStudent.Phone = (int.Parse(Console.ReadLine()));

                students.Add(newStudent);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }

            //since we have one list now its better that we use the foreach to loop through it
            foreach( var student in students )
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }
    }

    class Student
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        public int Phone;
    }
}
