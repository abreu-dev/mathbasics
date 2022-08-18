namespace MathBasics.ConsoleApp.Entities
{
    public class Classroom
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }

        public Classroom(string name, Teacher teacher)
        {
            Name = name;
            Teacher = teacher;
            Students = new List<Student>();
        }

        public void ApplyExam(Exam exam)
        {
            foreach (var student in Students)
            {
                foreach (var question in exam.Questions)
                {
                    var studentQuestion = new StudentQuestion(student, question);
                    student.StudentQuestions.Add(studentQuestion);
                }
            }
        }
    }
}
