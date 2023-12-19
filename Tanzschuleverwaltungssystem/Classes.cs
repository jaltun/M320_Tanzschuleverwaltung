namespace Tanzschuleverwaltungssystem
{
    public class Classes
    {
        public List<Student> Students { get; private set; }

        public Classes()
        {
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}