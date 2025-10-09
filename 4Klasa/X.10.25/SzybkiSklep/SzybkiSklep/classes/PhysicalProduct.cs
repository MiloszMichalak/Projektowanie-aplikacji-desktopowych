namespace SzybkiSklep;

public class PhysicalProduct : ProductItem
{
    public PhysicalProduct(string name, int price) : base(name, price)
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