using NUnit.Framework;

namespace Tanzschuleverwaltungssystem.Tests
{
    public class StudentTest
    {
        [Test]
        public void NinaDancing()
        {
            var student = new Student("Nina");
            student.Dancing(new List<string> { "Ballet", "Modern" });

            string expected = "Nina is dancing Ballet and Modern.";
            //Assert.That(expected, Is.EqualTo(Console.Out.ToString()));
            Assert.That(Console.Out.ToString(), Is.EqualTo(expected));
        }
    }
}