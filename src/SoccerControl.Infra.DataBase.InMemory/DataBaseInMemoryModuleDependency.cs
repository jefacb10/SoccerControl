using Microsoft.Extensions.DependencyInjection;
using SoccerControl.Domain.Adapters;
using SoccerControl.Infra.DataBase.InMemory.Repositories;

namespace SoccerControl.Infra.DataBase.InMemory
{
    public static class DataBaseInMemoryModuleDependency
    {
        public static void AddDataBaseInMemoryModule(this IServiceCollection services)
        {
            services.AddTransient<IClubRepository, ClubRepository>();
        }
    }
}
