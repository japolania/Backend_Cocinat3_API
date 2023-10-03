using Microsoft.AspNetCore.Mvc;

namespace Backend_Cocinat3_API.Controllers
{
    [ApiController]
    
    public class PublicacionesController : ControllerBase
    {
        [HttpGet]
        [Route("/api/[controller]/Publicaciones")]
        public IEnumerable<WeatherForecast> GetPublicaciones()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
            })
            .ToArray();
        }
    }
}
