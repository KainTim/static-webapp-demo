using ForecastDbLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAppCC.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController (ForeCastDbContext db) : ControllerBase
{
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Forecast> Get()
    {
        var forecasts = db.Forecasts;
        forecasts.ToQueryString();
        return forecasts.ToList();
    }
}
