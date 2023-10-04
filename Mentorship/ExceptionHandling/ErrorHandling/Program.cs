string[] names = new string[2];

names[0] = "Vincent";
names[1] = "Vincent";

try
{
    Console.WriteLine(names[2]);
}
catch (System.Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine(names[0]);
}