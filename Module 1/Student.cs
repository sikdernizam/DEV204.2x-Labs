using System;

namespace SelfAssesmentLab
{
    public class Student : Person
    {
        public Student(string name, int age, string address, string contactNo, string matricNo, int semester)
            : base(name, age, address, contactNo)
        {
            StMatricNo = matricNo;
            StSemester = semester;
            NoOfStudents++;
        }


        public int CountStudents()
        {
            return NoOfStudents;
        }

        public void DisplayStudentsInfo(Student[] students)
        {
            Console.WriteLine("=============== Printing Student Info: ===============");
            foreach (Student student in students)
            {
                Console.WriteLine("Name = {0}, Age = {1}, Address = {2}, Matric No.= {3}, Semester= {4}  ", student.Name, student.Age, student.Address, student.StMatricNo, student.StSemester);
            }
            Console.WriteLine("==============================");
        }


        public static int NoOfStudents { get; set; }

        public string StMatricNo { get; set; }

        public int StSemester { get; set; }
    }
}
