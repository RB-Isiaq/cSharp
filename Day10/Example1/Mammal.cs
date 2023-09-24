class Mammal : Animal
{
    public Mammal()
    {
        Console.WriteLine("Creating Mammal instance...");
    }
    // protected override void Eat()
    // {
    //     base.Eat();
    //     Console.WriteLine("I can eat as a mammal");
    // }
    public override void Eat()
    {
        // base.Eat();
        Console.WriteLine("I can eat as a mammal");
    }
    public override void Move()
    {
        Console.WriteLine("I move as a mammal");
    }
    public virtual void Sound()
    {
        Console.WriteLine("I can make sound as a mammal");
    }
}