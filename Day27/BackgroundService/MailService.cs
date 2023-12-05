using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackgroundService
{
    public class MailService
    {
        public void SendMail(User user)
        {
            Console.WriteLine("Send greeting to " + user.Email);
        }

        
    }
}