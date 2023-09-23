// 5. Write a program in C# Sharp to count the total number of words in a string.
// Test Data :
// Input the string : This is w3resource.com
// Expected Output :

// Total number of words in the string is : 3 

Console.WriteLine("This application checks for the total number of words.\nPlease enter a sentence below");
string? value = Console.ReadLine();
string[]? words = value?.Split(" ");
Console.Write("Total number of words in the string is : ");
Console.WriteLine(words?.Length);
