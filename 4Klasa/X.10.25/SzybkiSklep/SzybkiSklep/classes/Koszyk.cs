namespace SzybkiSklep;

public class Koszyk
{
    public List<ProductItem> products { get; }
    private static Koszyk _instance;
    public static Koszyk Instance => _instance ??= new Koszyk();

    private Koszyk()
    {
        products = new List<ProductItem>();
    }

    public int total(IDiscountStrategy discountStrategy)
    {
        return 1;
    }
}