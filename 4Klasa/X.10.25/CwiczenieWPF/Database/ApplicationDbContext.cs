using Microsoft.EntityFrameworkCore;

namespace CwiczenieWPF.Database;

public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=../../../kurczak.db");
        }
    }
    
    public DbSet<City> Cities { get; set; }
}