using Microsoft.AspNetCore.Mvc;

namespace Backend_Cocinat3_API.Controllers
{
   
    public class WeatherForecastController : ControllerBase
    {
       

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        
       
    }
}