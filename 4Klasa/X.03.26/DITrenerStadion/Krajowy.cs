namespace DITrenerStadion;

public class Krajowy : ITrener
{
    public override string ToString()
    {
        return ($"{Imie} {Nazwisko} {Wiek}");
    }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public byte Wiek { get; set; }
    
    public void Trenuj() {
        Console.WriteLine("Trener Krajowy");
    }
}