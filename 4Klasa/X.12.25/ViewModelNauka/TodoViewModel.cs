using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ViewModelNauka;

public partial class TodoViewModel : ObservableObject
{
    [ObservableProperty]
    private string _newText = String.Empty;
    [ObservableProperty]
    private bool _isDone;
    [ObservableProperty]
    private ToDoItem _selectedItem;
    
    public ObservableCollection<ToDoItem> Items { get; } = new();

    public TodoViewModel()
    {
        Items.Add(new ToDoItem { Text = "lol", IsDone = false });
        Items.Add(new ToDoItem { Text = "xd", IsDone = true });
    }

    [RelayCommand]
    private void AddNewItem()
    {
        Items.Add(new ToDoItem { Text = NewText, IsDone = IsDone});
        NewText = String.Empty;
    }

    [RelayCommand]
    private void RemoveItemSelected()
    {
        Items.Remove(SelectedItem);
        IsDone = false;
    }
    
    [RelayCommand]
    private void RemoveItem(ToDoItem item)
    {
        Items.Remove(item);
        IsDone = false;
    }
}