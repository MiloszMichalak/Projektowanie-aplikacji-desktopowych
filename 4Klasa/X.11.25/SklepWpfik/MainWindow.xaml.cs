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
using SklepWpfik.repository;
using SQLitePCL;

namespace SklepWpfik;

public partial class MainWindow : Window
{
    ShopDatabase db = new();
    protected override void OnInitialized(EventArgs e)
    {
        base.OnInitialized(e);
        
        db = new ShopDatabase();
        db.Database.EnsureCreated();
    }

    public MainWindow()
    {
        InitializeComponent();
        
        var cartService = new CartService(db);
        
        ComboBox.ItemsSource = cartService.GetCategories();
        ListBox.ItemsSource = cartService.GetProducts();
    }
}