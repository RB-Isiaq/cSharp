namespace Example2;

class Program
{
    static void Main(string[] args)
    {
        //         Animal animal = new Animal(); // Cannot create an instance of the abstract type or interface 'A
        // nimal' 
        Animal animal = new Mammal();
        animal.Eat();
    }
}
