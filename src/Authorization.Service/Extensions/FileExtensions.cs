using Microsoft.AspNetCore.Http;

namespace Authorization.Service.Extensions
{
    public static class FileExtensions
    {
        public static byte[] ToByteArray(this IFormFile file)
        {
            var array = new byte[file.Length];

            return array;
        }
    }
}
