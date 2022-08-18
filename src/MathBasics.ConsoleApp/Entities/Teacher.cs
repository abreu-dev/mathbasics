namespace MathBasics.ConsoleApp.Entities
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Teacher(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
