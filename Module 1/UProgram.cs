namespace SelfAssesmentLab
{
    public class UProgram
    {
        public UProgram(string pgName)
        {
            ProgramName = pgName;
        }

        public Degree Degree { get; set; }

        public string ProgramName { get; set; }
    }
}
