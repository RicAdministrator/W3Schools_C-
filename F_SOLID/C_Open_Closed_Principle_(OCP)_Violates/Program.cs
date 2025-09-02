// Open/Closed Principle(OCP)
// Software entities should be open for extension but closed for modification. 

// Violates OCP: Adding new shape types requires modifying the Calculator
public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}
public class Circle
{
    public double Radius { get; set; }
}
public class Square
{
    public double sideLength { get; set; }
}
public class AreaCalculator
{
    public double CalculateArea(object shape)
    {
        if (shape is Rectangle rect)
        {
            return rect.Width * rect.Height;
        }
        else if (shape is Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }
        // Adding new shapes requires modifying this method
        return 0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        AreaCalculator areaCalculator = new AreaCalculator();

        Rectangle rectangle = new Rectangle { Width = 100, Height = 50 };
        Console.WriteLine($"Area of Rectangle = {areaCalculator.CalculateArea(rectangle)}");

        Circle circle = new Circle { Radius = 100 };
        Console.WriteLine($"Area of Circle = {areaCalculator.CalculateArea(circle)}");
    }
}

// Output:
// Area of Rectangle = 5000
// Area of Circle = 31415.926535897932