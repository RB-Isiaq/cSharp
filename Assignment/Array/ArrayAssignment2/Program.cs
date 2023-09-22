// 2. Write a C# Sharp program to read n values in an array and display them in reverse order.
// Test Data :
// Input the number of elements to store in the array :3
// Input 3 number of elements in the array :
// element - 0 : 2
// element - 1 : 5
// element - 2 : 7
// Expected Output:
// The values store into the array are:
// 2 5 7
// The values store into the array in reverse are :
// 7 5 2

// SOLUTION
int[] elements = new int[5];

int? value;
for (int i = 0; i < elements.Length; i++)
{
    Console.WriteLine($"Enter element {elements.Length - i} into the array");
    value = Convert.ToInt32(Console.ReadLine());

    elements[i] = (int)value;
}

Console.WriteLine("The values store into the array are:");
foreach (int item in elements)
{
    Console.Write(item + " ");
}
Console.WriteLine("\nThe values store into the array in reverse are :");
foreach (int item in elements.Reverse())
{
    Console.Write(item + " ");
}

