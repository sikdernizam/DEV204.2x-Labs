using System;

namespace SelfAssesmentLab
{
    public class Degree
    {
        public Degree()
        {
        }

        public Degree(string degreeName)
        {
            DegreeName = degreeName;
        }

        public void DisplayDegreeInfo()
        {
            Console.WriteLine("Degree name is = {0}, Course under this degree={1}", DegreeName, Course.CourseName);
        }

        public Course Course { get; set; }

        public string DegreeName { get; set; }
    }
}
