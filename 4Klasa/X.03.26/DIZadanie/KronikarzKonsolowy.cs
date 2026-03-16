namespace DIZadanie;

public class KronikarzKonsolowy : IKronikarz
{
    public void Zapisz(Message message)
    {
        Console.WriteLine($"Kronikarz zapisał {message} w konsoli");
    }
}