namespace SzybkiSklep;

public class Koszyk
{
    public List<Product> products { get; set; };
    private static Koszyk _instance;
    public static Koszyk Instance =>  _instance ??= new Koszyk();

    public int total(IDiscountStrategy discountStrategy)
    {
        return 1;
    }
}