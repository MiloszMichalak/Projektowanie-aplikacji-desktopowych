using System.Windows;
using SqlLitEFWpf.Database;

namespace SqlLitEFWpf;
public partial class MainWindow : Window
{
    
    UserRepository userRepository = new();
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddButton_OnClick(object sender, RoutedEventArgs e)
    {
        var id = Convert.ToInt16(IdTextBox.Text);
        var name = NameTextBox.Text;
        var surname = SurnameTextBox.Text;
        var hobby = HobbyTextBox.Text;
        
        userRepository.AddUser(new User {Id = id, Name = name, Surname = surname, Hobby = hobby});
    }

    private void ShowButton_OnClick(object sender, RoutedEventArgs e)
    {
        var users = userRepository.GetUsers();
        MessageBox.Show(string.Join(", ", users));
    }
}