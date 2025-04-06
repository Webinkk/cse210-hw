namespace HomeworkAssignments
{
    public class Assignment
    {
        protected string StudentName { get; set; }
        protected string Topic { get; set; }

        // Constructor
        public Assignment(string studentName, string topic)
        {
            StudentName = studentName;
            Topic = topic;
        }

        // Method to return a summary of the assignment
        public virtual string GetSummary()
        {
            return $"{StudentName} - {Topic}";
        }
    }
}
