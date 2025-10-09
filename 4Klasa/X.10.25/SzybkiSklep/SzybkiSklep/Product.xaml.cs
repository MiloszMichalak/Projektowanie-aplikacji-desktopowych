using System.Windows;

namespace SzybkiSklep;

public partial class Product : Window
{
    public Product()
    {
        InitializeComponent();
        var koszyk = new Koszyk();
        
        string nazwa = name.Text;
        int cena = Convert.ToInt32(price.Text);
        Koszyk.Instance.products.Add(new DigitalProduct(nazwa, cena));
    }
}