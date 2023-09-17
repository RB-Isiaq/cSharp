namespace Example3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        long firstNumber = 2000;
        long secondNumber = 4000;
        long add = Add(firstNumber, secondNumber);
        long sub = Subtraction(firstNumber, secondNumber);
        long product = Product(firstNumber, secondNumber);
        float division = Divison(firstNumber, secondNumber);
        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} numbers is {add}");
        Console.WriteLine($"The difference of {firstNumber} and {secondNumber} numbers is {sub}");
        Console.WriteLine($"The product of {firstNumber} and {secondNumber} numbers is {product}");
        Console.WriteLine($"The division of {firstNumber} and {secondNumber} numbers is {division}");
        Console.WriteLine($"The modulo of {firstNumber} and {secondNumber} numbers is {Modulo(firstNumber, secondNumber)}");
    }

    private static long Add(long a, long b)
    {
        long sum = a + b;
        return sum;
    }
    private static long Subtraction(long a, long b)
    {
        long difference = a - b;
        return difference;
    }
    private static long Product(long a, long b)
    {
        long product = a * b;
        return product;
    }
    private static float Divison(float a, float b)
    {
        float result = a / b;
        return result;
    }
    private static long Modulo(long a, long b)
    {
        long remainder = a % b;
        return remainder;
    }
}
