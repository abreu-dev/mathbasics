namespace MathBasics.ConsoleApp.Execution
{
    public static class Executor
    {
        public static void Process()
        {
            var teacher = new Teacher("T Daniel");

            var classroom = new Classroom("C EBM", teacher);

            var student1 = new Student("S Tiago");
            var student2 = new Student("S Bruno");
            classroom.Students.Add(student1);
            classroom.Students.Add(student2);

            var exam = new Exam("E Reminder");

            var question1 = new Question(exam.Id, "1 + 1", "2");
            var question2 = new Question(exam.Id, "20 + 54", "74");
            var question3 = new Question(exam.Id, "15 + 1", "16");
            exam.Questions.Add(question1);
            exam.Questions.Add(question2);
            exam.Questions.Add(question3);

            classroom.ApplyExam(exam);

            student1.AnswerQuestion(question1.Id, "2");
            student1.AnswerQuestion(question2.Id, "75");
            student1.AnswerQuestion(question3.Id, "16");
        }
    }
}
