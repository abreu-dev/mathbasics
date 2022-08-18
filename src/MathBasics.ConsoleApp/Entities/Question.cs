namespace MathBasics.ConsoleApp.Entities
{
    public class Question
    {
        public Guid Id { get; set; }
        public Guid? ExamId { get; set; }

        public string Description { get; set; }
        public string Answer { get; set; }

        public Question(string description, string answer)
        {
            Id = Guid.NewGuid();
            Description = description;
            Answer = answer;
        }

        public Question(Guid examId, string description, string answer) : this(description, answer)
        {
            ExamId = examId;
        }
    }
}
