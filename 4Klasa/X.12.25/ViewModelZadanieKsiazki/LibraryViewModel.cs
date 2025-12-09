using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ViewModelZadanieKsiazki;

public partial class LibraryViewModel() : ObservableObject
{
    [ObservableProperty]
    private string _title;
    [ObservableProperty]
    private string _author;
    [ObservableProperty]
    private int _count;


    public ObservableCollection<BookState> BookStates { get; set; } = new();

    [RelayCommand]
    private void AddBook()
    {
        // var library = Library.GetInstance;
        BookStates.Add((new BookState(new Book(Title, Author), Count)));
    }
}