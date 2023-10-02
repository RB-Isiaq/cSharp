IsendMail sendMail = new SendYahoo();

SendMailToCustomer(sendMail, "I send a message");
void SendMailToCustomer(IsendMail sender, string message)
{
    sender.SendMail(message);
}