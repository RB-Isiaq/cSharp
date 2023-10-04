
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> queue1 = new Queue<string>();
        queue1.Enqueue("Lagos");
        queue1.Enqueue("Abuja");
        queue1.Enqueue("California");
        queue1.Enqueue("Texas");
        queue1.Enqueue("Otawwa");


        queue1.Dequeue();
        queue1.Dequeue();
        foreach (string location in queue1)
        {
            Console.WriteLine(location);
        }
    }
}