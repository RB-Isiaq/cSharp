namespace Example2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first vakue");
        long a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second vakue");
        int b = Convert.ToInt16(Console.ReadLine());

        long addition = a + b;
        long subtraction = a - b;
        long multiplication = a * b;
        double division = a / b;
        long modulo = a % b;

        Console.WriteLine($"The sum of {a} and {b} is {addition}");
        Console.WriteLine($"The difference of {a} and {b} is {subtraction}");
        Console.WriteLine($@"The product of {a} and {b} is {multiplication}");
        Console.WriteLine($"The division of {a} and {b} is {division}");
        Console.WriteLine($"The remainder of {a} and {b} is {modulo}");
    }
}
