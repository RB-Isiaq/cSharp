
namespace OOP
{
    public abstract class Student
    {
        public string? name { get; set; } = string.Empty;
        public string? email { get; set; } = string.Empty;
        public string? phone { get; set; } = string.Empty;


        public abstract void GetStudent();

        public void GetStudentDetails()
        {

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your email?");
            email = Console.ReadLine();
            Console.WriteLine("What is your phone number?");
            phone = Console.ReadLine();
            Console.WriteLine("\nStudent Name: " + name);
            Console.WriteLine("Student Email: " + email);
            Console.WriteLine("Student Phone: " + phone);
        }

        public virtual void GetStudentRole()
        {
            Console.WriteLine("I am a student");
            Console.WriteLine("Student Name: " + name);
        }
    }
}