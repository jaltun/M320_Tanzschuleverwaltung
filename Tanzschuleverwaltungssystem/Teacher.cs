namespace Tanzschuleverwaltungssystem
{
    public class Teacher : Person, ITeachable
    {
        public List<DanceClass> DanceClasses { get; private set; }

        public Teacher(string name) : base(name)
        {
            DanceClasses = new List<DanceClass>();
        }

        public void Teach(List<string> subjects)
        {
            Console.WriteLine($"{Name} is teaching {string.Join(" and ", subjects)}.");
        }
    }
}