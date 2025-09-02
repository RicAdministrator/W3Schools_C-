// Interface Segregation Principle (ISP)
// Clients should not be forced to depend on interfaces they do not use.

// Adheres to ISP: Segregate interfaces
using System.Security.Cryptography;

public interface IWorkable
{
    void Work();
}

public interface IFeedable
{
    void Eat();
}

public interface ISleepable
{
    void Sleep();
}

public class HumanWorker : IWorkable, IFeedable, ISleepable
{
    public void Work() { Console.WriteLine("Human working."); }
    public void Eat() { Console.WriteLine("Human eating."); }
    public void Sleep() { Console.WriteLine("Human sleeping."); }
}

public class RobotWorker : IWorkable
{
    public void Work() { Console.WriteLine("Robot working."); }
}

public class Program
{
    public static void Main(string[] args)
    {
        HumanWorker humanWorker = new HumanWorker();
        humanWorker.Work();
        humanWorker.Eat();
        humanWorker.Sleep();

        RobotWorker robotWorker = new RobotWorker();
        robotWorker.Work();
    }
}

// Output:
// Human working.
// Human eating.
// Human sleeping.
// Robot working.
