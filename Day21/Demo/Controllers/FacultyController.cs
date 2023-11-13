
using Microsoft.AspNetCore.Mvc;
using Demo.Models;
using Demo.Interfaces;

namespace Demo.Controllers
{


    [ApiController]
    [Route("api/[controller]")]

    public class FacultyController : ControllerBase
    {
        private readonly IFacultyService _facultyService;
        public FacultyController(IFacultyService facultyService)
        {
            _facultyService = facultyService;
        }

        [HttpGet]
        [Route("getfaculties")]
        public List<Faculty> GetFaculties()
        {
            return _facultyService.GetFaculties();
        }

        [HttpGet]
        [Route("faculties/{facultyId}")]
        public Faculty GetFacultyById(int facultyId)
        {
            return _facultyService.GetFacultyById(facultyId);
        }

        [HttpPost]
        [Route("addfaculties")]
        public void CreateFaculty([FromBody] Faculty faculty)
        {
            _facultyService.AddFaculty(faculty);
        }

        [HttpDelete]
        [Route("remove/{facultyId}")]
        public void DeleteFaculty(int facultyId)
        {
            _facultyService.DeleteFaculty(facultyId);
        }

        [HttpPatch]
        [Route("update")]
        public void UpdateFaculty([FromBody] Faculty faculty)
        {
            _facultyService.UpdateFaculty(faculty);
        }
    }
}