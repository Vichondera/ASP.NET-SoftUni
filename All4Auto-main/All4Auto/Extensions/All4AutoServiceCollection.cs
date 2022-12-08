namespace All4Auto.Extensions
{
    using All4Auto.Core.Contracts;
    using All4Auto.Core.Services;

    using All4Auto.DataProcessor;
    using All4Auto.DataProcessor.Common;

    public static class All4AutoServiceCollection
    {
        public static IServiceCollection AddAppServices(
           this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IVehicleService, VehicleService>();
            //services.AddScoped<IWebHostBuilder, WebHostBuilder>();
            //services.AddScoped<IGuard, Guard>();

            return services;
        }
    }
}
