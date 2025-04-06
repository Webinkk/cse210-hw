namespace HomeworkAssignments
{
    public class WritingAssignment : Assignment
    {
        private string Title { get; set; }

        // Constructor
        public WritingAssignment(string studentName, string topic, string title)
            : base(studentName, topic)
        {
            Title = title;
        }

        // Method to return the writing assignment summary
        public override string GetSummary()
        {
            return $"{base.GetSummary()} - {Title}";
        }

        // Method to get the writing assignment information
        public string GetWritingInfo()
        {
            return $"{Title} by {StudentName}";
        }
    }
}
