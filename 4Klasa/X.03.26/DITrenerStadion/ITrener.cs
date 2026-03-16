namespace DITrenerStadion;

public interface ITrener
{
    string Imie { get; set; }
    string Nazwisko { get; set; }
    byte Wiek {  get; set; }
    void Trenuj();
}