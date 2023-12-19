namespace Tanzschuleverwaltungssystem
{
    public class DanceClass
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; private set; }

        public DanceClass(Teacher teacher)
        {
            Teacher = teacher;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}