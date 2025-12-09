namespace ViewModelZadanieKsiazki;

public class BookState(Book book, int count)
{
    public Book Book = book;
    public int Count = count;

    public override string ToString()
    {
        return book + " " + Count;
    }
}