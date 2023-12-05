
namespace Demo2.UserModels
{
    public class MailService
    {
        public void SendMail(User user)
        {
            Console.WriteLine("Send greeting to " + user.Email);
        }


    }
}