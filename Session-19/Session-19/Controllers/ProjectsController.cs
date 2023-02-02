using Microsoft.AspNetCore.Mvc;
using Session_19.Models;

namespace Session_19.Controllers
{
    [ApiController]
    [Route("projects")]
    public class ProjectsController : Controller
    {
        [HttpGet]
        public IActionResult GetAllProjects()
        {
            var projects = new List<Project>()
            {
                new Project
                {
                    Id = Guid.NewGuid(),
                    ProjectName = "AMAZING PROJECT",
                    ProjectDescription = "SOMETHING AMAZING",
                    StartDate = DateTime.Now,
                    ProjectVersion = "1.0.0",
                    developers = new List<Developer>()


                },

                new Project
                {
                    Id = Guid.NewGuid(),
                    ProjectName = "SECRET PROJECT",
                    ProjectDescription = "SOMETHING EXTRORDINARY",
                    StartDate = DateTime.Now,
                    ProjectVersion = "3.0.0",
                    developers = new List<Developer>()


                }
            };

            return Ok(projects);
        }
    }
}
