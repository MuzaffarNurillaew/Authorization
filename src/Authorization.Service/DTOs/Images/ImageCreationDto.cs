using Microsoft.AspNetCore.Http;

namespace Authorization.Service.DTOs.Images
{
    public class ImageCreationDto
    {
        public long UserId { get; set; }
        public IFormFile File { get; set; }
    }
}
