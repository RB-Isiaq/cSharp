using System.Collections.Generic;
using System.IO;
public class CustomerService : ICustomerService
{
    public const string path = @"C:\Users\HP-PC\OneDrive\Desktop\C# bootcamp\cSharp\Day13\Example1\customer.txt";
    public List<Customer> GetCustomers()
    {
        List<Customer> customerList = new(); //new List<Customer>();
        string customerCSV = File.ReadAllText(path);
        string[] customerRecords = customerCSV.Split("\n");

        foreach (string customerItem in customerRecords)
        {
            string[] customers = customerItem.Split(",");

            Customer customer = new Customer();
            customer.Code = customers[0];
            customer.Name = customers[1];
            customer.Email = customers[2];
            customerList.Add(customer);
        }
        return customerList;
    }
}