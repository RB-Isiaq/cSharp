// 3. Write a program in C# Sharp to find the sum of all array elements.
// Test Data :
// Input the number of elements to be stored in the array :3
// Input 3 elements in the array :
// element - 0 : 2
// element - 1 : 5
// element - 2 : 8
// Expected Output :
// Sum of all elements stored in the array is : 15

// SOLUTION
int[] elements = new int[5];

int? value;

for (int i = 0; i < elements.Length; i++)
{
    Console.WriteLine($"Enter element {elements.Length - i} into the array");
    value = Convert.ToInt32(Console.ReadLine());

    elements[i] = (int)value;
}

Console.WriteLine($"Sum of all elements stored in the array is : {elements.Sum()}");

