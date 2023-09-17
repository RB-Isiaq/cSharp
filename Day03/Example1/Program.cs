namespace Example1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the principal?");
        // string? Principal = Console.ReadLine();
        double? principal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What is the rate?");
        string? Rate = Console.ReadLine();
        double? rate = Convert.ToDouble(Rate);
        Console.WriteLine("What is the time?");
        string? Time = Console.ReadLine();
        long? time = Convert.ToInt64(Time);

        double? simpleInterest = (principal * rate * time) /100;
        Console.WriteLine($"The simpleinterest is {simpleInterest}");

    }
}
