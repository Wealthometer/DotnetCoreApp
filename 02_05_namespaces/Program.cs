using System;
using System.Collections.Generic;
using System.Text; 

namespace _02_05_namespaces
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



                // Console.Write("Student Name: ");
                // newStudent.Name = (Console.ReadLine());

                // refactored the above code to Util class function
                newStudent.Name = Util.Console.Ask("Student Name: ");


                // refactored the above code to Util class function
                newStudent.Grade = (int.Parse(Util.Console.Ask("Student Grade: ")));

                // refactored the above code to Util class function
                newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

               // refactored the above code to Util class function
                newStudent.Address = Util.Console.Ask("Student Address: ");


                //refactored the code above to use the new traditional variable
                newStudent.Phone = int.Parse(Util.Console.Ask("Student Phone Number: "));

                students.Add(newStudent);

                // accessing the static variable through the class
                Student.Count++;

                // we output the student count for testing
                Console.WriteLine("Student Count: {0}", Student.Count);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }
        }
    }

    class Student
    { 
        // creating a static variable
        //static fields are not associated with object instance
        static public int Count = 0;
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;


        //creating a traditional c-sharp property
        public int Phone{
            set 
            {
                 phone = value; 
                 
                 //Console.WriteLine(phone);
                 
                 // test the functionality & output the traditional property
                 //Console.WriteLine(phone); 
            }
        }

        // we create a setter function to allow a access to the private method
        public void setPhone(int number)
        {
           phone = number; 
        }
        
    }

}
