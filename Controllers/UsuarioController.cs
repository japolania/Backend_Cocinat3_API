using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Backend_Cocinat3_API.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
       {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
       };
        [HttpGet]
        [Route("/api/[controller]/GetUser")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost]
        [Route("/api/[controller]/postUser")]
        public IEnumerable<WeatherForecast> PostUsuario()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPut]
        [Route("/api/[controller]/PutUsuario")]

        public async Task<ActionResult> PutUsuario()
        {
            return Ok();
        }

    }
}
