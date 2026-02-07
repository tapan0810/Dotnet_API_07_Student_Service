using Dotnet_API_07.Entites.Dtos;

namespace Dotnet_API_07.Services
{
    public interface IStudentServce
    {
        Task<PageResultDto<StudentReadDto>> GetAllStudent(PaginationDto pagnation);
    }
}
