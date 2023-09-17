// Collecting user details, and outputing it in a message;
string? name;
int? age;
string? country;
Console.WriteLine("Hello, please enter your name");
name = Console.ReadLine();
Console.WriteLine("How old are you?");
age = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Where do you reside?");
country = Console.ReadLine();

Console.WriteLine($"\nHello {name}, you are {age} years old, and your country of residence is {country}");