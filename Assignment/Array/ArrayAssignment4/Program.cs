// 4. Write a C# Sharp program to copy the elements of one array into another array.
// Test Data :
// Input the number of elements to be stored in the array :3
// Input 3 elements in the array :
// element - 0 : 15
// element - 1 : 10
// element - 2 : 12
// Expected Output:
// The elements stored in the first array are :
// 15 10 12
// The elements copied into the second array are :
// 15 10 12

// SOLUTION
int[] elements = new int[3];

int? value;
for (int i = 0; i < elements.Length; i++)
{
    Console.WriteLine($"Enter element {elements.Length - i} into the array");
    value = Convert.ToInt32(Console.ReadLine());

    elements[i] = (int)value;
}

int[] elementsClone = elements.ToArray();

Console.WriteLine("The elements stored in the first array are :");
foreach (int item in elements)
{
    Console.Write(item + " ");
}

Console.WriteLine("\nThe elements copied into the second array are :");

foreach (int item in elementsClone)
{
    Console.Write(item + " ");
}

