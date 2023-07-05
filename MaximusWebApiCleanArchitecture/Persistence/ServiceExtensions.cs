using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Persistence.Configuration;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            DatabaseSettings? settings = configuration.GetSection("DatabaseSettings").Get<DatabaseSettings>();
            string? connectionStringTemplate = configuration.GetConnectionString("DefaultConnection");

            string connectionString = string.Format(
                connectionStringTemplate,
                settings?.Server,
                settings?.Port,
                settings?.Database,
                settings?.User,
                settings?.Password,
                settings?.SecurityInfo,
                settings?.Timeout,
                true);

            services.AddDbContext<StationContext>(opt =>
                opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
            );
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IStationRepository, StationRepository>();
            services.AddScoped<IStationDataRepository, StationDataRepository>();
        }
    }
}
