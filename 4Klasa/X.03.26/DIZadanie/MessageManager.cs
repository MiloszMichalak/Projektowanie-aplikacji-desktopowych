namespace DIZadanie;

public class MessageManager(IArchiwista archiwista, IKronikarz kronikarz)
{
    public void WykonajZapisanie(Message message)
    {
        archiwista.Archiwizuj(message);
        kronikarz.Zapisz(message);
    }
}