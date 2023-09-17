namespace Example4;

class Program
{
    static void Main(string[] args)
    {
        bool isReady = false;

        while (isReady)
        {
            Console.WriteLine("This is a while loop...");
            Thread.Sleep(5 * 1000);
        }
    }
}
