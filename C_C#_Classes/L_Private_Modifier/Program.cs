using System.Xml;

class Car
{
    private string model = "Mustang";

    // By default, all members of a class are private if you don't specify an access modifier
    string year;   // private

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.model);
    }
}

// Output:
// Mustang