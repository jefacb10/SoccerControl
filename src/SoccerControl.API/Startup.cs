using Microsoft.OpenApi.Models;
using SoccerControl.Application;
using SoccerControl.Infra.DataBase.InMemory;
using SoccerControl.Infra.Email;

namespace SoccerControl.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            

            services.AddEmailModule();
            services.AddDataBaseInMemoryModule();
            services.AddApplicationModule();

            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "SoccerControl",
                        Version = "v1",
                        Description = "SoccerControl APIs",
                        Contact = new OpenApiContact
                        {
                            Name = "SoccerControl APIs"
                        }
                    });
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SoccerControl");
            });
        }

    }
}
