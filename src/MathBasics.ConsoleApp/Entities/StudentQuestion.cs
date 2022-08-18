namespace MathBasics.ConsoleApp.Entities
{
    public class StudentQuestion
    {
        public Guid Id { get; set; }
        public Student Student { get; set; }
        public Question Question { get; set; }

        public string? Answer { get; set; }
        public bool IsAnswer { get; set; }
        public bool? IsCorrect { get; set; }

        public StudentQuestion(Student student, Question question)
        {
            Id = Guid.NewGuid();
            Student = student;
            Question = question;
        }

        public void VerifyAnswer(string answer)
        {
            Answer = answer;
            IsCorrect = Answer == Question.Answer;
            IsAnswer = true;
        }
    }
}
