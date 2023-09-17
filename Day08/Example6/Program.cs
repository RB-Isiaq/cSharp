namespace Example6;

class Program
{
    static void Main(string[] args)
    {
        if(args.Length > 0) {
            for(int i = 0; i < args.Length; i++) {
                Console.WriteLine(args[i]);
            }
        }
        Console.WriteLine("Hello, World!");
    }
}
