using Application.Logging;
using Domain.Configuration;
using Logging.Logger;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NLog;

namespace Logging
{
    public static class ServiceExtensions
    {
        public static void ConfigureLogging(this IServiceCollection services, IConfiguration configuration)
        {
            LoggerSettings? settings = configuration.GetSection("LoggerSettings").Get<LoggerSettings>();

            LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), settings?.ConfigName));

            services.AddScoped<ILoggerManager, LoggerManager>();
        }
    }
}