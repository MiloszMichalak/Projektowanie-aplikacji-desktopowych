namespace DITrenerStadion;

public class Druzyna(ITrener trener)
{
    public string Nazwa {  get; set; }
    public string Miasto { get; set; } 
    
    public override string ToString()
    {
        return ($"{Nazwa} {Miasto}");
    }
}