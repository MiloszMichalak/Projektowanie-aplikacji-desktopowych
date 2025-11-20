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

namespace KoloryAplikacja;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        
    }

    private void RedRadio_OnChecked(object sender, RoutedEventArgs e)
    {
        if (RedRadio.IsChecked == true)
        {
            Frame.BorderBrush = new SolidColorBrush(Colors.Red);
        } else if (GreenRadio.IsChecked == true)
            Frame.BorderBrush = new SolidColorBrush(Colors.Green);
        else
        {
            Frame.BorderBrush =  new SolidColorBrush(Colors.Blue);    
        }
    }
}