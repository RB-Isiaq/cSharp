string name = "Michael";

string lowerValue = name.ToLower();
string upperValue = name.ToUpper();

string names = "Ade#Olu#Taiye#Ridwan";
string[] extractedNames = names.Split('#');

for (int i = 0; i < extractedNames.Length; i++)
{
    Console.WriteLine(extractedNames[i]);
}

Console.WriteLine(lowerValue);
Console.WriteLine(upperValue);