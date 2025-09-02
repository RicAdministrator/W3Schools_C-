// Single Responsibility Principle (SRP)
// A class should have only one reason to change.

// Violates SRP: User and Email concerns in one class
public class UserManager
{
    public void RegisterUser(string username, string password)
    {
        // Logic to register user
        Console.WriteLine($"User {username} registered.");
        SendWelcomeEmail(username);
    }

    private void SendWelcomeEmail(string username)
    {
        // Logic to send email
        Console.WriteLine($"Welcome email sent to {username}.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        UserManager userManager = new UserManager();
        userManager.RegisterUser("RicAdmin", "RicPassword");
    }
}

// Output:
// User RicAdmin registered.
// Welcome email sent to RicAdmin.
