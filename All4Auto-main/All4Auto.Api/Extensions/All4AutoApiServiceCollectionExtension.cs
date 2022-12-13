namespace Microsoft.Extensions.DependencyInjection
{
    using All4Auto.Core.Contracts;
    using All4Auto.Core.Services;
    using All4Auto.DataProcessor;
    using All4Auto.DataProcessor.Common;
    using Microsoft.EntityFrameworkCore;
    public static class All4AutoApiServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IVehicleService, VehicleService>();
           // services.AddScoped<IGuard, Guard>();

            return services;
        }

        public static IServiceCollection AddAll4AutoDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<All4AutoDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddScoped<IRepository, Repository>();

            return services;
        }
    }
}
