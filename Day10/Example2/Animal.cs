
abstract class Animal
{
    public string? Name { get; set; } = "Animal things";
    public Animal()
    {
        Console.WriteLine("Creating Animal instance...");
    }
    // protected virtual void Eat()
    // {
    //     Console.WriteLine("I can eat");
    // }
    public abstract void Eat();
    public abstract void Move();
}