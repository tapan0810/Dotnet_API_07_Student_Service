namespace Dotnet_API_07.Entites.Dtos
{
    public class PaginationDto
    {
        private const int MaxPageSize = 50;
        public int PageNumber = 1;
        private int _pageSize = 10; 
        public int PageSize
        {
            get => _pageSize;
            set =>_pageSize=value>MaxPageSize?MaxPageSize: value;
        }
    }
}
