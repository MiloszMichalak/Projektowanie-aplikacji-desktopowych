namespace SqlLitEFWpf.Database;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Hobby  { get; set; }

    public override string ToString()
    {
        return $"ID {Id}, Name {Name}, Surname {Surname}, Hobby {Hobby}\n";
    }
}