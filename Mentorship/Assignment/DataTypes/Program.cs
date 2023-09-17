// Variable declarations
string name;
char letter;
int smallNumber;
int smallNumberMax;
long largeNumber;
long largeNumberMax;
float smallDecimal;
float smallDecimalMax;
double mediumDecimal;
double mediumDecimalMax;
decimal largeDecimal;
decimal largeDecimalMax;
bool isBoolean;

// Variable assignments
name = "Ade";
letter = 'a';
smallNumber = int.MinValue;
smallNumberMax = int.MaxValue;
largeNumber = long.MinValue;
largeNumberMax = long.MaxValue;
smallDecimal = float.MinValue;
smallDecimalMax = float.MaxValue;
mediumDecimal = double.MinValue;
mediumDecimalMax = double.MaxValue;
largeDecimal = decimal.MinValue;
largeDecimalMax = decimal.MaxValue;
isBoolean = largeNumber > smallNumber;

// Printing to the console
Console.WriteLine(name);
Console.WriteLine(letter);
Console.WriteLine(smallNumber + " Min");
Console.WriteLine(smallNumberMax + " Max");
Console.WriteLine(largeNumber + " Min");
Console.WriteLine(largeNumberMax + " Max");
Console.WriteLine(smallDecimal + " Min");
Console.WriteLine(smallDecimalMax + " Max");
Console.WriteLine(mediumDecimal + " Min");
Console.WriteLine(mediumDecimalMax + " Max");
Console.WriteLine(largeDecimal + " Min");
Console.WriteLine(largeDecimalMax + " Max");
Console.WriteLine(isBoolean);