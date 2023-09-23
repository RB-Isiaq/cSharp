// 3. Write a C# Sharp program to separate individual characters from a string.
// Test Data :
// Input the string : w3resource.com
// Expected Output :

// The characters of the string are : 
// w  3  r  e  s  o  u  r  c  e  .  c  o  m 

Console.WriteLine("Please enter a string");
string? value = Console.ReadLine();
Console.WriteLine("The characters of the string are : ");

if (value != null)
{
    foreach (char character in value)
    {
        Console.Write(character + " ");
    }
}