
using Microsoft.AspNetCore.Mvc;
using Demo.Models;

namespace Demo.Controllers
{


    [ApiController]
    [Route("api/[controller]")]

    public class FacultyController : ControllerBase
    {
        List<Faculty> faculties = new List<Faculty>();
        public FacultyController()
        {
            faculties.Add(new Faculty()
            {
                Id = 1,
                Name = "Life Science"
            });
            faculties.Add(new Faculty()
            {
                Id = 2,
                Name = "Physical Science"
            });
        }

        [HttpGet]
        [Route("faculties")]
        public List<Faculty> GetFaculties()
        {
            return faculties;
        }

        [HttpPost]
        [Route("add")]
        public List<Faculty> CreateFaculty([FromBody] Faculty faculty)
        {
            faculties.Add(faculty);
            return faculties;
        }
    }
}