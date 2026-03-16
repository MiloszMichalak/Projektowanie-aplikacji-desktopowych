namespace DITrenerStadion;

public class Stadion
{
    public override string ToString()
    {
        return ($"{Miasto} {Adres}");
    }
    public string Miasto {  get; set; }
    public string Adres { get; set; }
}