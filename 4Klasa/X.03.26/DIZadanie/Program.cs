namespace DIZadanie;

static class Program
{
    static void Main(string[] args)
    {
        IArchiwista archiwista = new ArchiwistaCachowy();
        IKronikarz kronikarz = new KronikarzPlikowy();

        MessageManager messageManager = new MessageManager(archiwista, kronikarz);
        messageManager.WykonajZapisanie(new Message("Autor", "Tresc"));

        IArchiwista archiwista2 = new ArchiwistaBazoDanowy();
        IKronikarz kronikarz2 = new KronikarzKonsolowy();

        MessageManager messageManager2 = new MessageManager(archiwista2, kronikarz2);
        messageManager2.WykonajZapisanie(new Message("Autor2", "Tresc2"));
    }
}