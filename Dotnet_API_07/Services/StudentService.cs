using Dotnet_API_07.Data;
using Dotnet_API_07.Entites.Dtos;
using Dotnet_API_07.Entities.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_07.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _context;

        public StudentService(StudentDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResultDto<StudentReadDto>> GetStudents(PaginationDto pagination)
        {
            var query = _context.Students.AsQueryable();

            var totalRecords = await query.CountAsync();

            var students = await query
                .Skip((pagination.PageNumber - 1) * pagination.PageSize)
                .Take(pagination.PageSize)
                .Select(s => new StudentReadDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    PhoneNumber = s.PhoneNumber,
                    Email = s.Email,
                    Description = s.Description
                })
                .ToListAsync();

            return new PagedResultDto<StudentReadDto>
            {
                PageNumber = pagination.PageNumber,
                PageSize = pagination.PageSize,
                TotalRecords = totalRecords,
                TotalPages = (int)Math.Ceiling(totalRecords / (double)pagination.PageSize),
                Data = students
            };
        }
    }
}
