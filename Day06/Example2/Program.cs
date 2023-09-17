using System;
Console.WriteLine("What is your favorite continent?");
Console.WriteLine("1. Africa\n2. Europe\n3. Asia\n4. North America\n5. South America\n6. Australia\n7. Antartica\n");
int? choice = Convert.ToInt16(Console.ReadLine());

switch (choice)
{
    case 1:
    Console.WriteLine("hello Africa, tell me how you do");
    break;
    case 2:
    Console.WriteLine("hello Europe, tell me how you do");
    break;
    case 3:
    Console.WriteLine("hello Asia, tell me how you do");
    break;
    case 4:
    Console.WriteLine("hello North America, tell me how you do");
    break;
    case 5:
    Console.WriteLine("hello South America, tell me how you do");
    break;
    case 6:
    Console.WriteLine("hello Australia, tell me how you do");
    break;
    case 7:
    Console.WriteLine("hello Antartica, tell me how you do");
    break;
    default:
    Console.WriteLine("Choose a known continent");
    break;
}