// 1. Write a C# Sharp program that stores elements in an array and prints them.
// Test Data:
// Input 10 elements in the array:
// element - 0 : 1
// element - 1 : 1
// element - 2 : 2
// .......
// Expected Output :
// Elements in array are: 1 1 2 3 4 5 6 7 8 9

// SOLUTION
string[] elements = new string[10];

string? value;
for (int i = 0; i < elements.Length; i++)
{
    Console.WriteLine($"You have {elements.Length - i} items left to be stored");
    value = Console.ReadLine();

    if (value != null)
    {
        elements[i] = value;
    }
}

Console.Write("Elements in array are: ");
foreach (string item in elements)
{
    Console.Write(item + " ");
}






