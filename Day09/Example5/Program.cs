using System.IO;
using Example5;

bool status = true;

while (status)
{
    Customer customer = new Customer();
    Console.WriteLine("Provide Name");
    customer.Name = Console.ReadLine();

    Console.WriteLine("Provide Email");
    customer.Email = Console.ReadLine();
    string path = @"C:\Users\HP-PC\OneDrive\Desktop\C# bootcamp\cSharp\Day09\Example5\customer.txt";
    try
    {
        File.AppendAllText(path, customer.ToString());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }

    Console.WriteLine("Do you want to continue writing Customer Info \nTrue/False?");
    status = Convert.ToBoolean(Console.ReadLine());
}