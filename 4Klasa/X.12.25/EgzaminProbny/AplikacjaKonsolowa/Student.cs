namespace AplikacjaKonsolowa;

public class Student(uint id, string name, string surname, double average)
{
    public uint Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Surname { get; set; } = surname;
    public double Average { get; set; } = average;

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Surname: {Surname}, Average: {Average}";
    }
}