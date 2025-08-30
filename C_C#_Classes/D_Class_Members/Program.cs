class Car
{
    // Class members
    string color = "red";        // field
    int maxSpeed = 200;          // field    
    
    // Both private and public will work
    // private void fullThrottle() 
    public void fullThrottle()
    {
        Console.WriteLine("The car is going as fast as it can!");
    }

    static void Main(string[] args)
    {
        Car car = new Car();
        
        Console.WriteLine(car.color);
        Console.WriteLine(car.maxSpeed);

        car.fullThrottle();
    }
}

// Output:
// red
// 200
// The car is going as fast as it can!