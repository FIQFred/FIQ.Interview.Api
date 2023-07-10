using FIQ.Interview.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace FIQ.Interview.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController
    {
        [HttpGet(Name = "GetProjects")]
        public IEnumerable<Project> Get()
        {
            return new List<Project>();
        }
    }
}
