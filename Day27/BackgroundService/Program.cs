namespace BackgroundService;

class Program
{
    static void Main(string[] args)
    {
        UserService userService = new();
        while (true)
        {
            foreach (User user in userService.GetUsers())
            {
                MailService mail = new();
                mail.SendMail(user);
                Console.WriteLine("This is a background running service" + user.Name);
            }
            Thread.Sleep(5000);
        }
    }
}
