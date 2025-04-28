using ForDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentModel> GetStudents()
        {
            return CollageRepository.Students;

        }
    }
}
