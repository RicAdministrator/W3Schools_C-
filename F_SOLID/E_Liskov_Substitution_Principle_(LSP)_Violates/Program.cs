// The Liskov Substitution Principle (LSP) states that objects of a superclass should be replaceable 
// with objects of its subclasses without affecting the correctness of the program.

// LSP Violation Example (C#)
// This example uses the classic "Rectangle and Square" problem. A square is a rectangle,
// but setting its width and height independently breaks the expected behavior of a square.

using System.Xml;

public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

public class Square : Rectangle // Violation: Square inherits from Rectangle
{
    public override int Width
    {
        get { return base.Width; }
        set { base.Width = base.Height = value; } // Setting width also sets height
    }

    public override int Height
    {
        get { return base.Height; }
        set { base.Width = base.Height = value; } // Setting height also sets width
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Rectangle rect = new Square(); // Substituting Square for Rectangle
        rect.Width = 5;
        rect.Height = 4; // This will set Width to 4 as well, breaking Rectangle's expected behavior

        Console.WriteLine($"Area: {rect.GetArea()}"); // Expected: 20 (5*4), Actual: 16 (4*4)
    }
}

// Output
// Area: 16
