using System.Windows;

namespace SzybkiSklep;

public partial class Product : Window
{
    public Product()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object sender, RoutedEventArgs e)
    {
        string nazwa = name.Text.Trim();
        int cena = Convert.ToInt32(price.Text);
        Koszyk.Instance.products.Add(new DigitalProduct(nazwa, cena));
        Close();
    }
}