namespace SzybkiSklep;

public class Koszyk
{
    public List<ProductItem> products { get; }
    private static Koszyk _instance;
    private static readonly Lock _lock = new Lock();

    public static Koszyk Instance
    {
        get
        {
            lock (_lock)
            {
                return _instance ??= new Koszyk();
            }
        }
    }

    private Koszyk()
    {
        products = new List<ProductItem>();
    }

    public int total(IDiscountStrategy discountStrategy)
    {
        return 1;
    }
}