// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many students score do you want to capture");

int numOfScores = Convert.ToInt16(Console.ReadLine());

int[] scores = new int[numOfScores];

for (int i = 0; i < numOfScores; i++)
{
    Console.WriteLine($"Provide value for student record {1 + i}");
    scores[i] = Convert.ToInt16(Console.ReadLine());
}

for (int a = 0; a < numOfScores; a++)
{
    Console.WriteLine($"Student record {1 + a} is {scores[a]}");
}