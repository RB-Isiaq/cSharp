
namespace OOP
{
    public class PartTimeStudent : Student
    {

        public override void GetStudentRole()
        {
            Console.WriteLine("I am a part time student");
            Console.WriteLine("My Name is: " + name);
            Console.WriteLine("My Email is: " + email);
            Console.WriteLine("My Phone is: " + phone);
        }

        public override void GetStudent()
        {
            Console.WriteLine("I am a part time student. I go to school twice a week.");
        }
    }
}