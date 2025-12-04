using ForecastDbLib;

namespace WebAppCC.Services;

public class DbSeedingService(IServiceProvider serviceProvider) : BackgroundService
{

    protected override Task ExecuteAsync(CancellationToken stoppingToken) {
        var scope = serviceProvider.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<ForeCastDbContext>();
        List<Forecast> forecasts =
        [
            new ()
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                TemperatureC = 25,
                Summary = "Sunny"
            },
            new ()
            {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(10)),
            TemperatureC = 12,
            Summary = "Cloudy"
            },
            new ()
            {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-1)),
            TemperatureC = -12,
            Summary = "Rainy"
            }
        ];
        db.SaveChanges();
        return Task.CompletedTask;
    }
}
