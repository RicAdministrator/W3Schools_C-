class Car
{
    string color = "red";
    //static string color = "red";

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.color);

        // If you want to do this, make the field static
        //Console.WriteLine(color);
    }
}

// Output:
// red