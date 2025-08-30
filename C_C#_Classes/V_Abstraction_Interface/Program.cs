interface IAnimal
{
    // An interface is a completely "abstract class",
    // which can only contain abstract methods and properties (with empty bodies):

    // By default, members of an interface are abstract and public

    // Interfaces can contain properties and methods, but not fields

    // On implementation of an interface, you must override all of its methods

    // class can implement multiple interfaces

    string Name { get; set; }
    void animalSound(); // interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal
{
    public string Name { get; set; }

    public void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();  // Create a Pig object
        myPig.Name = "Peppa";
        Console.WriteLine(myPig.Name);
        myPig.animalSound();
    }
}

// Output:
// Peppa
// The pig says: wee wee