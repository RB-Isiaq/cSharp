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
Console.WriteLine("This app stores a number of element and check for duplicates.\nInput the number of elements to be stored in the array:");
int n = Convert.ToInt32(Console.ReadLine());

int[] elements = new int[n];

for (int i = 0; i < elements.Length; i++)
{
    Console.WriteLine($"input element {i + 1}");
    elements[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Total number of duplicate elements found in the array is : ");

int duplicateCount = 0;

for (int i = 0; i < elements.Length; i++)
{
    for (int j = i + 1; j < elements.Length; j++)
    {
        if (elements[i] == elements[j])
        {
            duplicateCount++;
            break; // Exit the inner loop when a duplicate is found
        }
    }
}

Console.Write(duplicateCount);