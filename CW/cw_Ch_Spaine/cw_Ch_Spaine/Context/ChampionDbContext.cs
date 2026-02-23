using cw_Ch_Spaine.Entitys;
using Microsoft.EntityFrameworkCore;

namespace cw_Ch_Spaine.Context;

public class ChampionDbContext:DbContext
{
    public DbSet<Player>Players { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=ChampionSpaine;User Id=sa;Password=macAZUREnew!1390;TrustServerCertificate=True;");
    }
}