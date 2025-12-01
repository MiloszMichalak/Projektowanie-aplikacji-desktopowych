using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ViewModelNauka;

public partial class TodoViewModel : ObservableObject
{
    [ObservableProperty]
    private string _text;
    [ObservableProperty]
    private bool _isDone;

    public ObservableCollection<TodoViewModel> Items { get; set; } = new();
    


}