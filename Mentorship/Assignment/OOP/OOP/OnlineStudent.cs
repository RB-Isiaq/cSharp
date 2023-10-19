
namespace OOP
{
    public class OnlineStudent : Student
    {
        public override void GetStudent()
        {
            Console.WriteLine("\nThis student is an online student");
            Console.WriteLine("He studies remotely");
        }
        public override void GetStudentRole()
        {
            Console.WriteLine("I am an online student! And I love online classes.");

        }
    }
}