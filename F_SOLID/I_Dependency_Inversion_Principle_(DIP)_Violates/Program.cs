// Dependency Inversion Principle (DIP)
// High - level modules should not depend on low-level modules;
// both should depend on abstractions. Abstractions should not depend on details;
// details should depend on abstractions. 

// Violates DIP: High-level Switch depends on low-level LightBulb
public class LightBulb
{
    public void TurnOn() { Console.WriteLine("Light bulb on."); }
    public void TurnOff() { Console.WriteLine("Light bulb off."); }
}

public class Switch
{
    private LightBulb _bulb;
    public Switch(LightBulb bulb)
    {
        _bulb = bulb;
    }
    public void Operate()
    {
        _bulb.TurnOn(); // Tight coupling
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LightBulb lightBulb = new LightBulb();

        Switch sw = new Switch(lightBulb);
        sw.Operate();
    }
}

// Output:
// Light bulb on.