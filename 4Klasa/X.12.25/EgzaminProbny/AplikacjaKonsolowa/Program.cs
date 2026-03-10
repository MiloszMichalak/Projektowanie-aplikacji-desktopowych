using System.Text.RegularExpressions;

namespace AplikacjaKonsolowa;

public class Program
{
    public static void Main(string[] args)
    {
        var manager = new StudentManager();
        while (true)
        {
            ShowMenu();

            var choice = GetIntFromUser("Podaj opcje(1-7): ");
            switch (choice)
            {
                case 1:
                    uint uid;
                    Console.Write("Podaj id studenta:");
                    while (!uint.TryParse(Console.ReadLine(), out uid))
                    {
                        Console.WriteLine("\nBledne dane, sprobuj ponownie.");
                        Console.Write("Podaj id studenta: ");
                    }

                    var name = GetValidatedStringFromUser("Podaj imie:");
                    var surname = GetValidatedStringFromUser("Podaj nazwisko:");
                    
                    double average;
                    Console.Write("Podaj srednia studenta:");
                    while (!double.TryParse(Console.ReadLine(), out average) || average < 2.0 || average > 5.0 ||
                           average % 0.5 != 0)
                    {
                        Console.WriteLine("\nBledna srednia, sprobuj ponownie.");
                        Console.Write("Podaj srednia studenta: ");
                    }
                    var student = new Student(uid, name, surname, average);
                    manager.AddStudent(student);
                    
                    break;
                case 2:
                    var id = GetIntFromUser("Podaj id studenta: ");
                    manager.RemoveStudent(id);
                    break;
                case 3:
                    manager.DisplayStudentsInTab();
                    break;
                case 4: 
                    manager.SortByAverageDescending();
                    break;
                case 5:
                    Console.WriteLine(manager.CalculateOverallAverage());
                    break;
                case 6:
                    Console.Write("Podaj nazwisko studenta: ");
                    var input = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("\t"+manager.GetStudentBySurname(input));
                    break;
                case 7: 
                    return;
                default:
                    Console.WriteLine("B|AD");
                    break;
            }
        }
    }
    
    private static void ShowMenu()
    {
        Console.WriteLine("\tCo chcesz zrobic?");
        Console.WriteLine("1. Dodac studenta");
        Console.WriteLine("2. Usunac studenta po ID");
        Console.WriteLine("3. Wyswietlic studentow w formie tabeli");
        Console.WriteLine("4. Posortowac studentow po sredniej malejaco");
        Console.WriteLine("5. Obliczyc srednia wszystkich studentow");
        Console.WriteLine("6. Znalesc studenta po nazwisku");
        Console.WriteLine("7. Wyjsc z programu");
    }

    private static int GetIntFromUser(string message)
    {
        int result;
        Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("\nBledne dane, sprobuj ponownie.");
            Console.Write(message);
        }
        return result;
    }

    private static string GetValidatedStringFromUser(string message)
    {
        var regex = new Regex("^[A-Z][a-z]+$");
        Console.Write(message);
        var name = Console.ReadLine() ?? String.Empty;
        while (!regex.IsMatch(name))
        {
            Console.WriteLine("\nBledny format");
            Console.Write(message);
            name = Console.ReadLine() ?? String.Empty;
        }

        return name;
    }
}