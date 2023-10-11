using System.Net;
using System.Net.Mail;

public class EmailService : IEmailService
{
    private readonly EmailSetting _emailSetting;

    public EmailService(EmailSetting emailSetting)
    {
        _emailSetting = emailSetting;
    }
    public bool SendMessage(Customer customer, MyMessage message)
    {
        var smtpClient = new SmtpClient(_emailSetting.Server)
        {
            Port = 587,
            Credentials = new NetworkCredential(_emailSetting.Username, _emailSetting.Password),
            EnableSsl = true,
        };
        if (customer != null)
        {
            smtpClient.Send(message.From, customer.Email, message.Subject, message.Body);

        }
        return true;
    }
}
