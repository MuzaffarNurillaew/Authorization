using Authorization.Domain.Commons;
using Authorization.Domain.Enums;

namespace Authorization.Domain.Entities
{
    public class User : Auditable
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; } = UserRole.User;

        public ICollection<Image> Images { get; set; }
    }
}
