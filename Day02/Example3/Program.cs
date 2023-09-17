namespace Example3;

class Program
{
    static void Main(string[] args)
    {
        int time;
        float rate;
        double principal;
        double simpleInterest;

        time = 1;
        rate = 12.5F;
        principal = 10003000.0;

        simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine("S. I. is " + simpleInterest);
        Console.WriteLine($"S. I. is {simpleInterest}");
    }
}
