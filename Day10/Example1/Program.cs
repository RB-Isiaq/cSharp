namespace Example1;

class Program
{
    static void Main(string[] args)
    {
        // Mammal mm = new Mammal();
        // // mm.Eat();
        // mm.Move();
        // mm.Sound();  
        Animal animal = new Animal();
        animal.Move();
        animal.Eat();

        Mammal mammal = new Mammal();
        mammal.Move();
        mammal.Eat();

        Dog dog = new Dog();
        Console.WriteLine($"Name is {dog.Name}");
        dog.Eat();
        dog.Move();
        dog.Sound();
    }
}
