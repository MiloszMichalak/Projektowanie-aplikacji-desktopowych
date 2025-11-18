namespace SklepWpfik.models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public override string ToString()
    {
        return Name + " " + Category;
    }
}