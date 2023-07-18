using K101MovieApp.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace K101MovieApp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IFilmService _filmService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IFilmService filmService)
    {
        _logger = logger;
        _filmService = filmService;
    }


    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_filmService.Hello());
    }
}

