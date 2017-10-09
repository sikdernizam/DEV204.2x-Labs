using System;

namespace SelfAssesmentLab
{
    public class Teacher : Person
    {
        public Teacher(string name, int age, string address, string contact, string qualification)
            : base(name, age, address, contact)
        {
            TeacherName = name;
            TeacherAge = age;
            TeacherQualification = qualification;
        }

        public void DisplayTeachersInfo(Teacher[] teachers)
        {
            Console.WriteLine("=============== Printing Teacher Info: ===============");
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine("Name = {0}, Age = {1}, Address = {2}, Contact= {3}, Qualification = {4}  ", teacher.Name, teacher.Age, teacher.Address, teacher.ContactNo, teacher.TeacherQualification);
            }
            Console.WriteLine("==============================");
        }

        public string TeacherName { get; set; }

        public int TeacherAge { get; set; }

        public string TeacherQualification { get; set; }
    }
}
