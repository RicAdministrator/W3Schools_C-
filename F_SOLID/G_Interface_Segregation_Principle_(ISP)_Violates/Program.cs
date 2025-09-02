// Interface Segregation Principle (ISP)
// Clients should not be forced to depend on interfaces they do not use.

// Violates ISP: IWorker includes methods not all workers need
using System.Drawing;

public interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}

public class Robot : IWorker
{
    public void Work() { Console.WriteLine("Robot working."); }
    public void Eat() { /* Robots don't eat */ } // Forced to implement unused method
    public void Sleep() { /* Robots don't sleep */ } // Forced to implement unused method
}

public class Program
{
    public static void Main(string[] args)
    {
        Robot robot = new Robot();
        robot.Work();
        robot.Eat();
        robot.Sleep();
    }
}

// Output:
// Robot working.