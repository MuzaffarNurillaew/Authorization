using Authorization.Service.DTOs.Images;

namespace Authorization.Service.DTOs.Users
{
    public class UserDto
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public ICollection<ImageDto> Images { get; set; }
    }
}
