using Dotnet_API_07.Entites.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_API_07.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentPaginationController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<PagedResultDto<StudentReadDto>>> GetStudents(
            [FromQuery] PaginationDto pagination)
        {
            var result = await _service.GetStudents(pagination);
            return Ok(result);
        }
    }
}
