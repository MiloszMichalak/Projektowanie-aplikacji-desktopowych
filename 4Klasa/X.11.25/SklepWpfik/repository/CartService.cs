using SklepWpfik.models;

namespace SklepWpfik.repository;

public class CartService(ShopDatabase db)
{
    public List<Category> GetCategories()
    {
        return db.Categories.ToList();
    }

    public List<Product> GetProducts()
    {
        return db.Products.ToList();
    }
}