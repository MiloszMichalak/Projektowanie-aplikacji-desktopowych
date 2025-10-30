namespace CwiczenieWPF.Database;

public class CityRepository
{
    public List<City> GetCities()
    {
        using var context = new ApplicationDbContext();
        return context.Cities.ToList();
    }
}