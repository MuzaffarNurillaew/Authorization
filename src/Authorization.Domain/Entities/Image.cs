using Authorization.Domain.Commons;

namespace Authorization.Domain.Entities
{
    public class Image : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public string Path { get; set; }
    }
}
