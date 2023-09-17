// using System;

Console.WriteLine("What is your favorite continent?");
Console.WriteLine("1. Africa\n2. Europe\n3. Asia\n4. North America\n5. South America\n6. Australia\n7. Antartica\n");
int? choice = Convert.ToInt16(Console.ReadLine());

switch (choice)
{
    case (int)Continents.Africa:
    Console.WriteLine("hello Africa, tell me how you do");
    break;
    case (int)Continents.Europe:
    Console.WriteLine("hello Europe, tell me how you do");
    break;
    case (int)Continents.Asia:
    Console.WriteLine("hello Asia, tell me how you do");
    break;
    case (int)Continents.NorthAmerica:
    Console.WriteLine("hello North America, tell me how you do");
    break;
    case (int)Continents.SouthAmerica:
    Console.WriteLine("hello South America, tell me how you do");
    break;
    case (int)Continents.Australia:
    Console.WriteLine("hello Australia, tell me how you do");
    break;
    case (int)Continents.Antartica:
    Console.WriteLine("hello Antartica, tell me how you do");
    break;
    default:
    Console.WriteLine("Choose a known continent");
    break;
}