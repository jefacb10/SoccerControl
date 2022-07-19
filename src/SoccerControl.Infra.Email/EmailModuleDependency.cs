using Microsoft.Extensions.DependencyInjection;
using SoccerControl.Domain.Adapters;
using SoccerControl.Infra.Email.Operations;

namespace SoccerControl.Infra.Email
{
    public static class EmailModuleDependency
    {
        public static void AddEmailModule(this IServiceCollection services)
        {
            services.AddTransient<IEmailAdapter, EmailManager>();
        }
    }
}
