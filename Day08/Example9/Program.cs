Console.WriteLine("Please provide first value");
string? firstValue = Console.ReadLine();

Console.WriteLine("Please provide second value");
string? secondValue = Console.ReadLine();

bool? result = firstValue?.Contains(secondValue);
Console.WriteLine(result);
