using System.Security.Claims;
using Tanzschuleverwaltungssystem;

class Program
{
    static void Main()
    {
        // Create teachers
        var balletTeacher = new Teacher("John");
        var modernTeacher = new Teacher("Alice");
        var hiphopTeacher = new Teacher("Mike");
        var jazzTeacher = new Teacher("Sarah");

        // Create dance classes
        //var balletClass = new DanceClass(balletTeacher);
        //var modernClass = new DanceClass(modernTeacher);
        //var hiphopClass = new DanceClass(hiphopTeacher);
        //var jazzClass = new DanceClass(jazzTeacher);

        // Create students
        var student1 = new Student("Nina");
        var student2 = new Student("Tom");
        var student3 = new Student("Emma");

        // Assign students to dance classes
        //balletClass.AddStudent(student1);
        //balletClass.AddStudent(student2);
        //modernClass.AddStudent(student1);
        //hiphopClass.AddStudent(student2);
        //jazzClass.AddStudent(student3);

        // Teacher teaches the classes
        balletTeacher.Teach(new List<string> { "Ballet", "Modern" });
        modernTeacher.Teach(new List<string> { "Modern" });
        hiphopTeacher.Teach(new List<string> { "Hip Hop" });
        jazzTeacher.Teach(new List<string> { "Jazz", "Dance Condition" });

        // Students dance in their classes
        student1.Dancing(new List<string>{ "Ballet", "Modern"});
        student2.Dancing(new List<string>{ "Hip Hop", "Jazz" });
        student3.Dancing(new List<string> { "Jazz" });
    }
}