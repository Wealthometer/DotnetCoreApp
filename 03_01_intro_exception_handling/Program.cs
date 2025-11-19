using System;
using System.Collections.Generic;
using System.Text; 

namespace _03_01_intro_exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            // we call our import function to see dat student data was imported
            Import();

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
                // it's also refactored with exceptions to use tryparse
                //the out parameter will give us the result
                int.TryParse(Util.Console.Ask("Student Grade: "), out newStudent.Grade);

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
    
        static void Import()
        {
           var importedStudent = new Student("Jenny", 86, "december 9", "Lekki", 123456);

           //test to see dat the import is working
           Console.WriteLine(importedStudent.Name);
        }
    }

    // this class will unify & abstract the concepts off student & teacher
    class Member
    {
        public string Name;
        public string Address;
        // the protected keyword is like private but it only works with inheritance
        protected int phone;

        //creating a traditional c-sharp property
        public int Phone {
            set 
            {
                 phone = value; 
                 
                 //Console.WriteLine(phone);
                 
                 // test the functionality & output the traditional property
                 //Console.WriteLine(phone); 
            }
        }
    }

    //this syntax represents inheritance which means student is inheriting member class
    class Student : Member
    { 
        // creating a static variable
        //static fields are not associated with object instance
        static public int Count = 0;
        public int Grade;
        public string Birthday;
        

        // we create an empty constructor
        public Student()
        {

        }

        //the constructor requires parameters so we cant pass empty constructors
        // a constructor usually uses the same name as the class name
        // a contructor will run as soon as the object is created or constructed
        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }

        
    }

    class Teacher : Member
    { 
        public string Subject;

    }

}
