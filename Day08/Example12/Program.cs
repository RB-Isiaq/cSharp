int a = 0;
int b = 0;
try
{
Console.WriteLine("Provide first value");
 a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Provide second value");
 b = Convert.ToInt32(Console.ReadLine());
    
}
catch (Exception ex)
{
    Console.WriteLine("Catch block is executed");
    Console.WriteLine(ex.Message);
}

int result = a + b;
Console.WriteLine(result);