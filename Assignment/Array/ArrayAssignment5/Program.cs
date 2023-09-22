// 5. Write a C# Sharp program in to count duplicate elements in an array.
// Test Data :
// Input the number of elements to be stored in the array :3
// Input 3 elements in the array :
// element - 0 : 5
// element - 1 : 1
// element - 2 : 1
// Expected Output :
// Total number of duplicate elements found in the array is : 1

// SOLUTION
int[] elements = new int[5];

int? value;
for (int i = 0; i < elements.Length; i++)
{
    Console.WriteLine($"Enter element {elements.Length - i} into the array");
    value = Convert.ToInt32(Console.ReadLine());

    elements[i] = (int)value;
}

Console.WriteLine("Total number of duplicate elements found in the array is :");
// int[] duplicateCount = { };

// for (int item = 0; item < elements.Length; item++)
// {
//     // int previous = elements[item]
//     if (duplicateCount.Contains(elements[item]))
//     {
//         duplicateCount[item] = item;
//     }
//     Console.Write(item + " ");
// }