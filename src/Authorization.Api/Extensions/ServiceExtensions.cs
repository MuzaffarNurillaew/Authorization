using Authorization.Data.IRepositories;
using Authorization.Data.Repositories;

namespace Authorization.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection service)
        {
            // repo
            service.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            // automapper
            //service.AddAutoMapper();
        }
    }
}
