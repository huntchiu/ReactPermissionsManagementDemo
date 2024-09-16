using Microsoft.AspNetCore.Mvc;

namespace ReactPermissionsManagementDemo.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok();
        }

    }
}

