using System.Text.Json;

namespace DIZadanie;

public interface ISerializuj
{
    string Serializuj()
    {
        return JsonSerializer.Serialize(this);
    }
}