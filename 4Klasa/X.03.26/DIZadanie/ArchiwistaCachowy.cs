namespace DIZadanie;

public class ArchiwistaCachowy : IArchiwista
{
    public void Archiwizuj(Message message)
    {
        Console.WriteLine($"Zapisano do cachu {message}");
    }
}