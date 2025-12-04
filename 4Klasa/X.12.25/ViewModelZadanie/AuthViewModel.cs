using CommunityToolkit.Mvvm.ComponentModel;

namespace ViewModelZadanie;

public partial class AuthViewModel : ObservableObject
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty] 
    private string _lastName;
    
    public string FullName => $"{Name} {LastName}";
    
    partial void OnNameChanged(string value) => OnPropertyChanged(nameof(FullName));
    partial void OnLastNameChanged(string value) => OnPropertyChanged(nameof(FullName));
}