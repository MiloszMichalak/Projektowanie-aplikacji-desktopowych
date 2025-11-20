using Microsoft.EntityFrameworkCore;

namespace KoloryAplikacja;

public class ColorDatabase : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}