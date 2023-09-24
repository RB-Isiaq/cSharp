using System.IO;
using Example5;

bool status = true;

while(status)
{
    Customer customer = new Customer();
    Console.WriteLine("Provide Name");
    customer.Name = Console.ReadLine();

    Console.WriteLine("Provide Email");
    customer.Email = Console.ReadLine();
    string path = @"C:\data\customers.txt";
    try
    {
        File.WriteAllText(path, customer.ToString());
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }

    Console.WriteLine("Do you want to continue writing Customer Info \n True/False?");
    status = Convert.ToBoolean(Console.ReadLine());
}