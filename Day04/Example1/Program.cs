namespace Example1;

class Program
{
    static void Main(string[] args)
    {
        int result = getValuePrefixValue();
        int result2 = getValuePostfixValue();
        int result3 = getValue();

        int a = 20;
        int b = 100;
        long c = 10000;
        long d = 10000;

        bool negate = true;

        bool exclusiveAnd = false & GenerateStatus();
        bool logicalAnd = false && GenerateStatus();
        bool exclusiveOr = false || GenerateStatus();
        bool logicalOr = false || GenerateStatus();

        Console.WriteLine($"The value of a is {result}");
        Console.WriteLine($"The value of a is {result2}");
        Console.WriteLine($"The value of a is {result3}");
        Console.WriteLine($"The boolean is {a > b}");
        Console.WriteLine($"The boolean is {a < b}");
        Console.WriteLine($"The boolean is {a >= b}");
        Console.WriteLine($"The boolean is {a <= b}");
        Console.WriteLine($"The boolean is {a <= b}");
        Console.WriteLine($"The boolean is {c == d}");
        Console.WriteLine($"The boolean is {d >= b}");
        Console.WriteLine($"The bool value is {negate}");
        Console.WriteLine($"The negated value is {!negate}");
        Console.WriteLine($"The exclusive AND value is {exclusiveAnd}");
        Console.WriteLine($"The logical AND value is {logicalAnd}");
        Console.WriteLine($"The exclusive OR value is {exclusiveOr}");
        Console.WriteLine($"The logical OR value is {logicalOr}");
    }

    private static int getValuePrefixValue()
    {
        int a = 10;
        return ++a;
    }
    private static int getValuePostfixValue()
    {
        int a = 10;
        return a++;
    }
    private static int getValue()
    {
        int a = 10;
        int b = 20;
        return a *= b;
    }
    private static bool GenerateStatus()
    {
        string status = "This is the status of execution";
        Console.WriteLine(status);
        return true;
    }
}
