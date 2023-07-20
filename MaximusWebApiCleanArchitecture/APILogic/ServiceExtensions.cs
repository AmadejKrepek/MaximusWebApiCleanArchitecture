using APILogic.Configuration;
using APILogic.Logic;
using Application.Logic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace APILogic
{
    public static class ServiceExtensions
    {
        public static void ConfigureAPILogic(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<HttpClient>();
            services.Configure<BaseUrlOptions>(options => configuration.GetSection("BaseUrlOptions").Bind(options));
            services.AddScoped<ICallApi, CallPileusAPI>();
        }
    }
}