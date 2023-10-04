Customer customer1 = new Customer();
customer1.Name = "Ridwan";
customer1.Email = "ridwan@gmail.com";
customer1.Phone = "09030404";
Customer.CustomerType = "Silver";
ShowCustomer(customer1);

Customer customer2 = new Customer();
customer2.Name = "Bukola";
customer2.Email = "Bukola@gmail.com";
customer2.Phone = "09030404";
ShowCustomer(customer2);

Customer customer3 = new Customer();
customer3.Name = "Isiaq";
customer3.Email = "Isiaq@gmail.com";
customer3.Phone = "09030404";
ShowCustomer(customer3);

static void ShowCustomer(Customer customer)
{
    Console.WriteLine($"Customer Name: {customer.Name}");
    Console.WriteLine($"Customer Email: {customer.Email}");
    Console.WriteLine($"Customer Phone: {customer.Phone}");
    Console.WriteLine($"Customer Type: {Customer.CustomerType}");
    Console.WriteLine($"================================================");
}