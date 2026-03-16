namespace DIZadanie;

public class KronikarzPlikowy : IKronikarz
{
    public void Zapisz(Message message)
    {
        File.AppendAllLines("../../../wiadomosc.txt", [message.ToString()]);
    }
}