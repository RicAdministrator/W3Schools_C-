// Open/Closed Principle(OCP)
// Software entities should be open for extension but closed for modification. 

// Adheres to OCP: Use polymorphism
public interface IShape
{
    double CalculateArea();
}
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double CalculateArea() => Width * Height;
}
public class Circle : IShape
{
    public double Radius { get; set; }
    public double CalculateArea() => Math.PI * Radius * Radius;
}
public class Square : IShape
{
    public double sideLength { get; set; }
    public double CalculateArea() => sideLength * sideLength;
}
public class NewAreaCalculator
{
    public double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}
class Program
{
    static void Main(string[] args)
    {
        NewAreaCalculator newAreaCalculator = new NewAreaCalculator();

        Rectangle rectangle = new Rectangle { Width = 100, Height = 50 };
        Console.WriteLine($"Area of Rectangle = {newAreaCalculator.CalculateArea(rectangle)}");

        Circle circle = new Circle { Radius = 100 };
        Console.WriteLine($"Area of Circle = {newAreaCalculator.CalculateArea(circle)}");

        Square square = new Square { sideLength = 100 };
        Console.WriteLine($"Area of Square = {newAreaCalculator.CalculateArea(square)}");
    }
}

// Output:
// Area of Rectangle = 5000
// Area of Circle = 31415.926535897932
// Area of Square = 10000