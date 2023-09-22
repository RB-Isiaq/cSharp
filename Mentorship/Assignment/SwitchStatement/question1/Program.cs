Console.WriteLine("Hello user, Please enter your name");
string? name = Console.ReadLine();

Console.WriteLine("What is your gender?");
string? gender = Console.ReadLine()?.ToUpper();

const string MALE = "MALE";
const string FEMALE = "FEMALE";
const string OTHERS = "OTHERS";

string message = $"Hello {name}, you are a ";

switch (gender)
{
    case MALE:
        Console.WriteLine(message + MALE);
        break;
    case FEMALE:
        Console.WriteLine(message + FEMALE);
        break;
    case OTHERS:
        Console.WriteLine(message + OTHERS);
        break;
    default:
        Console.WriteLine(message + MALE);
        break;
}

