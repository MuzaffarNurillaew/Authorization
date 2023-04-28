using Authorization.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Api.Extensions
{
    public static class DataExtensions
    {
        public static void ApplyMigration(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<AuthorizationDbContext>();

            db.Database.Migrate();
        }
    }
}
