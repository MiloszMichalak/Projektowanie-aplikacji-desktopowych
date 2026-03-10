using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CwiczenieMVVM;

public partial class ToDoViewModel : ObservableObject
{
    public ObservableCollection<Item> Items { get; } = new();
    
    [ObservableProperty]
    private string _newText = string.Empty;
    [ObservableProperty]
    private string _newDescription = string.Empty;

    [RelayCommand]
    private void AddItem()
    {
        Items.Add(new Item {Title = NewText, Description = NewDescription});
    }
}