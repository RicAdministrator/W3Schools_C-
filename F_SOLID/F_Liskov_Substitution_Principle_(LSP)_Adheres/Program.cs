// LSP Fix(C#)
// To fix this, we can introduce a common interface or abstract class for shapes and separate the
// Rectangle and Square into distinct classes that don't violate each other's contracts.

public interface IShape
{
    int GetArea();
}

public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

public class Square : IShape
{
    public int SideLength { get; set; }

    public int GetArea()
    {
        return SideLength * SideLength;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IShape rect = new Rectangle { Width = 5, Height = 4 };
        Console.WriteLine($"Rectangle Area: {rect.GetArea()}"); // Output: 20

        IShape square = new Square { SideLength = 5 };
        Console.WriteLine($"Square Area: {square.GetArea()}"); // Output: 25
    }
}

// Output:
// Rectangle Area: 20
// Square Area: 25