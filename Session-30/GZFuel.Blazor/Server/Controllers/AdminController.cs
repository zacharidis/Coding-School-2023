using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GZFuel.Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from AdminController");
        }
    }
}
