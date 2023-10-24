
ICustomerService customerService = new CustomerService();
List<Customer> customers = customerService.GetCustomers();

EmailSetting emailSetting = new EmailSetting();
emailSetting.Server = "smtp.gmail.com";
emailSetting.Username = "isiaqridwanbukola1999@gmail.com";
emailSetting.Password = "09030984108";

IEmailService emailService = new EmailService(emailSetting);

foreach (Customer customer in customers)
{
    MyMessage message = new MyMessage();
    message.From = emailSetting.Username;
    message.Body = $"Dear {customer.Name}, \n Trust you are good.";

    bool result = emailService.SendMessage(customer, message);

    if (result)
    {
        Console.WriteLine($"Message sent to {customer.Name} @ {customer.Email}");
    }
}