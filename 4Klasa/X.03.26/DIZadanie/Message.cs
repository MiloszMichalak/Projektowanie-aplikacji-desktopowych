using System.Runtime.Serialization;

namespace DIZadanie;

public struct Message : ISerializuj
{
    private string _autor;
    private string _tresc;
    private DateTime _dataUtworzenia;

    public Message(
        string autor,
        string tresc
    )
    {
        _autor = autor;
        _tresc = tresc;
        _dataUtworzenia = DateTime.Now;
    }
    
    public override string ToString() => $"[{_dataUtworzenia}] {_autor}: {_tresc}";
}