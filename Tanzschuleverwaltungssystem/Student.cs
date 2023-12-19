namespace Tanzschuleverwaltungssystem
{
    public class Student : Person
    {
        public List<DanceClass> DanceClasses { get; private set; }

        public Student(string name) : base(name)
        {
            DanceClasses = new List<DanceClass>();
        }

        public void Dancing(List<string> danceStyle)
        {
            Console.WriteLine($"{Name} is dancing {string.Join(" and ", danceStyle)}.");
        }
    }
}