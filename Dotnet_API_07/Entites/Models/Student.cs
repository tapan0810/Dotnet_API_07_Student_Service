namespace Dotnet_API_07.Entites.Models
{
    public class Student
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
