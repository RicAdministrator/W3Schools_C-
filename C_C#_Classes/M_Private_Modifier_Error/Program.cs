using System.Diagnostics.Metrics;

class Car
{
    private string model = "Mustang";
}

class Program
{
    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.model); // 'Car.model' is inaccessible due to its protection level
    }
}