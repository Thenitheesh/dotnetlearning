using Microsoft.AspNetCore.Mvc;
using repository;
using entities;
using services;

namespace EcommerceWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    // [HttpGet(Name = "GetWeatherForecast")]
    // public IEnumerable<WeatherForecast> Get()
    // {
    //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     {
    //         Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
    //         TemperatureC = Random.Shared.Next(-20, 55),
    //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     })
    //     .ToArray();
    // }

    // GET /WeatherForecast
    [HttpGet]
    public IEnumerable<Product> Get()
    {
        var productRepository = new ProductRepository();
        var productService = new ProductService(productRepository);
        return productService.GetAllProducts();
    }

    // GET /GetProducts (explicit shortcut route)
    [HttpGet]
    [Route("/GetProducts")]
    public IEnumerable<Product> GetProducts()
    {
        var productRepository = new ProductRepository();
        var productService = new ProductService(productRepository);
        return productService.GetAllProducts();
    }
}
