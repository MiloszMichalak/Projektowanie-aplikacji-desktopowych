namespace ViewModelZadanieKsiazki;

public class Book(string title, string author)
{
    public string Title { get; set; } = title;
    public string Author { get; set; } = author;

    public override string ToString()
    {
        return Title + " " + Author;
    }
}