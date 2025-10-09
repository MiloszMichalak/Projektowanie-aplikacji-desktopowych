namespace SzybkiSklep;

public abstract class ProductItem
{
    public string Name;
    public int Price;

    protected ProductItem(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public abstract int getPrice();
    public abstract string getName();
}