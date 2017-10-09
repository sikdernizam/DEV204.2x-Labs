using System;

namespace SelfAssesmentLab
{
    public class Course
    {
        public Course()
        {

        }

        public Course(string courseName)
        {
            CourseName = courseName;
        }

        public Course(Student[] students, Teacher[] teachers, string courseName)
        {
            Student = students;
            Teacher = teachers;
            CourseName = courseName;
        }

        public void DisplayCourseInfo()
        {
            Console.WriteLine("No of students in this course = {0}",SelfAssesmentLab.Student.NoOfStudents);
        }

        public Student[] Student { get; set; }

        public Teacher[] Teacher { get; set; }

        public string CourseName { get; set; }

    }
}
