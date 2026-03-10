namespace AplikacjaKonsolowa;

public class StudentManager
{
    private List<Student> _students = new();
    
    public void AddStudent(Student student)
    {
        _students.Add(student);
    }
    
    public void RemoveStudent(int id)
    {
        _students.RemoveAll(student => student.Id == id);
    }

    public void SortByAverageDescending()
    {
        _students = _students.OrderByDescending(student => student.Average).ToList();
    }

    public void DisplayStudentsInTab()
    {
        Console.WriteLine("ID\tName\tSurname\tAverage");
        foreach (var student in _students)
        {
            Console.WriteLine($"{student.Id}\t{student.Name}\t{student.Surname}\t{student.Average}");
        }
    }

    public double CalculateOverallAverage()
    {
        return _students.Average(student => student.Average);
    }

    public Student? GetStudentBySurname(string surname)
    {
        return _students.FirstOrDefault(student => student.Surname == surname);
    }
}