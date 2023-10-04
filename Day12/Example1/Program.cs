using System.Collections.Generic;

List<Customer> customers = new List<Customer>();

Customer customer1 = new Customer();
customer1.Name = "John Smith";
customer1.Email = "John2@example";

Customer customer2 = new Customer();
customer2.Name = "David Smith";
customer2.Email = "david@example";

Customer customer3 = new Customer();
customer3.Name = "David Smith";
customer3.Email = "david@example";

customers.Add(customer1);
customers.Add(customer2);

foreach (Customer customer in customers)
{
    Console.WriteLine(customer.CustomerId);
    Console.WriteLine(customer.Name);
    Console.WriteLine(customer.Email);
    Console.WriteLine();
}
// List<int> scores = new List<int>();

// scores.Add(56);
// scores.Add(52);
// scores.Add(64);

// foreach (int item in scores)
// {
//     Console.WriteLine(item);
// }
// for (int item = 0; item < scores.Count; item++)
// {
//     Console.WriteLine(scores[item]);
// }