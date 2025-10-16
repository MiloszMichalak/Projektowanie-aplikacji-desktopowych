using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SzybkiSklep;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int index = 0;
    List<ProductItem> listaProduktow = Koszyk.Instance.products;
    public MainWindow()
    {
        InitializeComponent();
        KeyDown += MainWindows_KeyDown;
        
        UpdateUI();
    }

    private void MainWindows_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Key == Key.A && Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
        {
            var newWindow = new Product();

            newWindow.Show();
        }
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        listaProduktow = Koszyk.Instance.products;
        if (listaProduktow == null || listaProduktow.Count == 0) return;
        if (index < listaProduktow.Count - 1)
        {
            index++;
            UpdateUI();
        }
    }

    private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
    {
        listaProduktow = Koszyk.Instance.products;
        if (listaProduktow == null || listaProduktow.Count == 0) return;
        if (index > 0)
        {
            index--;
            UpdateUI();
        }
    }
    
    private void UpdateUI()
    {
        if (listaProduktow == null || listaProduktow.Count == 0)
        {
            name.Text = "Brak produktów";
            cena.Text = string.Empty;
            return;
        }

        if (index < 0) index = 0;
        if (index >= listaProduktow.Count) index = listaProduktow.Count - 1;

        var item = listaProduktow[index];
        name.Text = item?.Name ?? string.Empty;
        cena.Text = item != null ? item.Price.ToString() : string.Empty;
    }
}