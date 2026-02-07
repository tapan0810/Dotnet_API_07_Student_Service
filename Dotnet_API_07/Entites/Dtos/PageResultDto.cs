
using System.Runtime.InteropServices;

namespace Dotnet_API_07.Entites.Dtos
{
    public class PageResultDto<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalRRecord { get; set; }
        public int TotalPages { get; set; }
        public List<T> Data {  get; set; }
    }
}
