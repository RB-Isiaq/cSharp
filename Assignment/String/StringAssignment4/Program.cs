// 4. Write a program in C# Sharp to print individual characters of the string in reverse order.
// Test Data :
// Input the string : w3resource.com
// Expected Output :

// The characters of the string in reverse are : 

// m  o  c  .  e  c  r  u  o  s  e  r  3  w 

Console.WriteLine("Please enter a string");
string? value = Console.ReadLine();
Console.WriteLine("The characters of the string in reverse are :");

if (value != null)
{
    foreach (char character in value.Reverse())
    {
        Console.Write(character + " ");
    }
}