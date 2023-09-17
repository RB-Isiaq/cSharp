
string[] names = new string[] {"Jamee", "Ade", "Wale"};

try
{
Console.WriteLine(names[0]);
Console.WriteLine(names[4]);
    
}
catch (Exception ex)
{
    Console.WriteLine("Catch block is executed");
    Console.WriteLine(ex.Message);
}
finally
{
Console.WriteLine("This line will run anyway");
}