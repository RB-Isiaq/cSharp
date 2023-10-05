using System.Collections.Generic;

Stack<int> numbers = new Stack<int>();

numbers.Push(1);
numbers.Push(2);
numbers.Push(3);
numbers.Push(4);
numbers.Push(5);

foreach (int item in numbers)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine(numbers.Peek());

// Last in first out
// 5
// 4
// 3
// 2
// 1

// 5