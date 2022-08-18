namespace MathBasics.ConsoleApp.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<StudentQuestion> StudentQuestions { get; set; }

        public Student(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            StudentQuestions = new List<StudentQuestion>();
        }

        public void AnswerQuestion(Guid questionId, string answer)
        {
            var question = StudentQuestions.FirstOrDefault(x => x.Question.Id == questionId);

            if (question == null) return;

            question.VerifyAnswer(answer);
        }
    }
}
