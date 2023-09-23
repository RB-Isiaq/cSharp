// See https://aka.ms/new-console-template for more information
const string filepath = @"C:\Users\HP-PC\OneDrive\Desktop\C# bootcamp\cSharp\Assignment\message.txt";

Console.WriteLine("Enter the words to be stored in the file");

string? elements = Console.ReadLine();
File.WriteAllText(filepath, elements);
string text = File.ReadAllText(filepath);

Console.WriteLine(text);

