public interface IEmailService
{
    public bool SendMessage(Customer customer, MyMessage message);
}