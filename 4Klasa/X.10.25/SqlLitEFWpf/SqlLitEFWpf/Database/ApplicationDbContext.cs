using Microsoft.EntityFrameworkCore;

namespace SqlLitEFWpf.Database;

public class ApplicationDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=SQLite.db");
        }
    }

    public DbSet<User> Users { get; set; }
}