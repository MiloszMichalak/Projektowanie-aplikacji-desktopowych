namespace DIZadanie;

public class ArchiwistaBazoDanowy : IArchiwista
{
    public void Archiwizuj(Message message)
    {
        Console.WriteLine($"Zapisano do bazy danych {message}");
    }
}