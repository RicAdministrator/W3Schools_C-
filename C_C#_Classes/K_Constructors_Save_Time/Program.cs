class Program
{
    static void Main(string[] args)
    {
        // Without constructor
        Car Ford = new Car();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;

        Car Opel = new Car();
        Opel.model = "Astra";
        Opel.color = "white";
        Opel.year = 2005;

        Console.WriteLine(Ford.model);
        Console.WriteLine(Opel.model);

        // With constructor
        Car Ford2 = new Car("Mustang", "Red", 1969);
        Car Opel2 = new Car("Astra", "White", 2005);

        Console.WriteLine(Ford2.model);
        Console.WriteLine(Opel2.model);
    }
}

// Output:
// Mustang
// Astra
// Mustang
// Astra