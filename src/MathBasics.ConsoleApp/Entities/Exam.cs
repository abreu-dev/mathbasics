namespace MathBasics.ConsoleApp.Entities
{
    public class Exam
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Question> Questions { get; set; }

        public Exam(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Questions = new List<Question>();
        }
    }
}
