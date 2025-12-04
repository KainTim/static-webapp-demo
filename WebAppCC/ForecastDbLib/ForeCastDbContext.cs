using Microsoft.EntityFrameworkCore;

namespace ForecastDbLib;

public class ForeCastDbContext : DbContext
{
    public DbSet<Forecast> Forecasts { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=tcp:sql-kainzt.database.windows.net,1433;Initial Catalog=sql-kainzt;Persist Security Info=False;User ID=kainzt;Password=Timleo2701;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=5;");
    }
}
