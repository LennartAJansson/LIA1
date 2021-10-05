
namespace Microsoft.Extensions.DependencyInjection
{
    using Exempel;
    using Exempel.Abstract;

    using Microsoft.EntityFrameworkCore;

    public static class MyServiceExtensions
    {
        public static IServiceCollection AddMyServices(this IServiceCollection services, string connectionString)
        {
            services.AddTransient<IMyService, MyService>();
            services.AddDbContext<IUnitOfWork, WorkloadsDb>(builder =>
            {
                builder.UseSqlServer(connectionString);
            });
            return services;
        }
    }
}
