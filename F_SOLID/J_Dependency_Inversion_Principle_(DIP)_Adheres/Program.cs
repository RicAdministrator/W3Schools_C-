// Dependency Inversion Principle (DIP)
// High - level modules should not depend on low-level modules;
// both should depend on abstractions. Abstractions should not depend on details;
// details should depend on abstractions. 

// Adheres to DIP: Depend on abstraction
public interface IDevice
{
    void TurnOn();
    void TurnOff();
}

public class NewLightBulb : IDevice
{
    public void TurnOn() { Console.WriteLine("New Light bulb on."); }
    public void TurnOff() { Console.WriteLine("New Light bulb off."); }
}

public class NewSwitch
{
    private IDevice _device;
    public NewSwitch(IDevice device) // Injected dependency
    {
        _device = device;
    }
    public void Operate()
    {
        _device.TurnOn(); // Depends on abstraction
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IDevice newLightBulb = new NewLightBulb();

        NewSwitch newSwitch = new NewSwitch(newLightBulb);
        newSwitch.Operate();
    }
}

// Output:
// New Light bulb on.