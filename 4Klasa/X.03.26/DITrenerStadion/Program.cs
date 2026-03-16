namespace DITrenerStadion;

static class Program
{
    static void Main(string[] args)
    {
        ITrener t1 = new Krajowy();
        t1.Imie = "Imie";
        t1.Nazwisko = "Nazwisko";
        t1.Wiek = 24;
        Console.WriteLine(t1);
        
        ITrener t2 = new Krajowy();
        t2.Imie = "eimI";
        t2.Nazwisko = "oksiwzaN";
        t2.Wiek = 42;
        Console.WriteLine(t2);
        
        Druzyna d1 = new Druzyna(t1);
        d1.Nazwa = "Czarni";
        d1.Miasto = "Kaźmierz";
        Console.WriteLine(d1);
        
        Druzyna d2 = new Druzyna(t1);
        d2.Nazwa = "inrazC";
        d2.Miasto = "zreimźaK";
        Console.WriteLine(d2);
        
        Stadion s1 = new Stadion();
        s1.Miasto = "Poznań";
        s1.Adres = "Bułgarska";
        Console.WriteLine(s1);
        
        Stadion s2 = new Stadion();
        s2.Miasto = "Warszawa";
        s2.Adres = "Łaziękowska";
        Console.WriteLine(s2);
        
        Stadion s3 = new Stadion();
        s3.Miasto = "Komorniki";
        s3.Adres = "Za biedni na stadion";
        Console.WriteLine(s3);
        
        DruzynaImpl DI = new DruzynaImpl(s1, d1);
    }
}