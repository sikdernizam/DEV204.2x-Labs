using System;

namespace SelfAssesmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Student Object
            Student[] students =
            {
                new Student("Nizam Uddin", 27, "Dhaka","01715123456", "C083005",8),
                new Student("Redwanul Hoque", 28, "Chittagong", "01715123457","C083004",5),
                new Student("Redwanul Arefin", 28, "Chittagong", "01715123458","C083002",5),
            };
            //students[0].DisplayStudentsInfo(students);

            //One Teacher Object
            Teacher[] teachers =
            {
                new Teacher("Samsul Arefin", 35, "Khutakhali", "123456", "B.Sc M.Sc in CSE")
            };
            //teachers[0].DisplayTeachersInfo(teachers);

            //Instantiate a Course object called "Programming with C#"
            Course course = new Course("Programming in C#");

            //Add 3 students to Course object
            course.Student = students;

            //Add Teacher object to Course object
            course.Teacher = teachers;

            //Instantiate a Degree object , such as Bachelor
            Degree bachelorDegree = new Degree("Bachelor");

            //Add Course object to Degree object
            bachelorDegree.Course = course;


            //Instantiate a UProgram object called Information Technology
            UProgram uProgram = new UProgram("Information Technology");

            //Add the Degree object to the UProgram object
            uProgram.Degree = bachelorDegree;

            Console.WriteLine("Printing Records");
            Console.WriteLine("************************");
            //The name of the program and the degree it contains
            Console.WriteLine("The name of the program = {0} and the degree it contains = {1}", uProgram.ProgramName, bachelorDegree.DegreeName);

            //The name of the course in the degree
            Console.WriteLine("The name of the course in the degree = {0}", course.CourseName);

            //The count of the number of students in the course.
            Console.WriteLine("The count of the number of students in the course = {0}", students[0].CountStudents());

            Console.ReadLine();
        }
    }
}
