// Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.

namespace MyApplication
{
    enum Level
    {
        Low,
        Medium,
        High
    }
    class Program
    {
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }
    }
}

// Output:
// Medium