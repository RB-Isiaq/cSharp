Console.WriteLine("Hello user, Please enter your name");
string? name = Console.ReadLine();

Console.WriteLine("What is your gender?\nplease select an option below:\n1. Male\n2. Female\n3. Other");

int? genderOption = Convert.ToInt32(Console.ReadLine());

const string MALE = "MALE";
const string FEMALE = "FEMALE";
const string OTHERS = "OTHERS";

string message = $"Hello {name}, you are a ";

switch (genderOption)
{
    case (int)Gender.MALE:
        Console.WriteLine(message + MALE);
        break;
    case (int)Gender.FEMALE:
        Console.WriteLine(message + FEMALE);
        break;
    case (int)Gender.OTHERS:
        Console.WriteLine(message + OTHERS);
        break;
    default:
        Console.WriteLine(message + MALE);
        break;
}

// Enum declaration
enum Gender
{
    MALE = 1,
    FEMALE = 2,
    OTHERS = 3,
}
