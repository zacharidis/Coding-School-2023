using Microsoft.AspNetCore.Mvc;
using Session_19.Models;

namespace Session_19.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevelopersController : Controller
    {


        [HttpGet]
        public IActionResult GetAllDevelopers()
        {
            var developers = new List<Developer>()

            {
                new Developer
                {
                    Id = Guid.NewGuid(),
                    Name = "George",
                    Surname = "Zachs",
                    YearsOfExperience = 1,
                    projects = new List<Project>()

                },

                new Developer
                {
                    Id = Guid.NewGuid(),
                    Name = "Zedd",
                    Surname = "Geo",
                    YearsOfExperience = 1,
                    projects = new List<Project>()

                }


            };
            return Ok(developers);
        }
    }
}
