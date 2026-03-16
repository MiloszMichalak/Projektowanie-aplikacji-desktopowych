namespace DILearning;

public interface ILogger
{
    void Log(string text);
}

public interface IEmailService
{
    void Send(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string text)
    {
        Console.WriteLine(text);
    }
}

class EmailService : IEmailService
{
    public void Send(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}

class UserService(ILogger logger, IEmailService email)
{
    public void CreateUser()
    {
        logger.Log("User created");
        email.Send("Welcome!");
    }
}

class Program
{
    static void Main()
    {
        ILogger logger = new ConsoleLogger();
        IEmailService email = new EmailService();

        UserService userService = new UserService(logger, email);

        userService.CreateUser();
    }
}