// Single Responsibility Principle (SRP)
// A class should have only one reason to change.

// Adheres to SRP: Separate responsibilities
public class UserRegistrationService
{
    public void RegisterUser(string username, string password)
    {
        // Logic to register user
        Console.WriteLine($"User {username} registered.");
    }
}

public class EmailService
{
    public void SendWelcomeEmail(string username)
    {
        // Logic to send email
        Console.WriteLine($"Welcome email sent to {username}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        UserRegistrationService userRegistrationService = new UserRegistrationService();
        userRegistrationService.RegisterUser("RicAdmin", "RicPassword");

        EmailService emailService = new EmailService();
        emailService.SendWelcomeEmail("RicAdmin");
    }
}

// Output:
// User RicAdmin registered.
// Welcome email sent to RicAdmin.
