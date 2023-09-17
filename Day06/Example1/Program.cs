Console.WriteLine("What is your favorite continent?");
string? choice = Console.ReadLine();
const string Africa = "africa";
const string Europe = "europe";
const string NorthAmerica = "north america";
const string SouthAmerica = "south america";
const string Asia = "asia";
const string Australia = "australia";
const string Antartica = "Antartica";

choice = choice?.ToLower();
switch (choice)
{
    case Africa:
    Console.WriteLine("hello Africa, tell me how you do");
    break;
    case Europe:
    Console.WriteLine("hello Europe, tell me how you do");
    break;
    case Asia:
    Console.WriteLine("hello Asia, tell me how you do");
    break;
    case NorthAmerica:
    Console.WriteLine("hello North America, tell me how you do");
    break;
    case SouthAmerica:
    Console.WriteLine("hello South America, tell me how you do");
    break;
    case Australia:
    Console.WriteLine("hello Australia, tell me how you do");
    break;
    case Antartica:
    Console.WriteLine("hello Antartica, tell me how you do");
    break;
    default:
    Console.WriteLine("Choose a known continent");
    break;
}