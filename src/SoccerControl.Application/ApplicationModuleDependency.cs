using Microsoft.Extensions.DependencyInjection;
using SoccerControl.Application.Services;
using SoccerControl.Domain.Services;

namespace SoccerControl.Application
{
    public static class ApplicationModuleDependency
    {
        public static void AddApplicationModule(this IServiceCollection services)
        {
            services.AddTransient<IClubService, ClubServiceManager>();
        }
    }
}
