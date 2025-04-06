namespace HomeworkAssignments
{
    public class MathAssignment : Assignment
    {
        private string Section { get; set; }
        private string Problems { get; set; }

        // Constructor
        public MathAssignment(string studentName, string topic, string section, string problems)
            : base(studentName, topic)
        {
            Section = section;
            Problems = problems;
        }

        // Method to return the math assignment summary
        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Section {Section} - {Topic}";
        }

        // Method to display the math homework list
        public string GetMathHomeworkList()
        {
            return $"Section {Section} Problems {Problems}";
        }
    }
}
