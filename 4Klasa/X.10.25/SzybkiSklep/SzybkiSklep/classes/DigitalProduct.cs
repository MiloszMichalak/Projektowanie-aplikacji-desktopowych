namespace SzybkiSklep;

public class DigitalProduct : ProductItem
{
    public DigitalProduct(string name, int price) : base(name, price)
    {
    }

    public override int getPrice()
    {
        return Price;
    }

    public override string getName()
    {
        return Name;
    }
}