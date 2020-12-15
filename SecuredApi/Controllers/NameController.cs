using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SecuredApi.Controllers
{
    [ApiController]
    [Route("api/Arpit")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        [HttpGet]
        public string Get()
        {
            return "Arpit Malik";
        }
    }
}
