using DatabaseService.Core.Interfaces;
using DatabaseService.Core.Service;
using Microsoft.OpenApi;

namespace DatabaseService
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddControllers();

            services.AddSingleton<IDbservice, DbService>();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(cfg =>
            {
                cfg.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "DB API",
                    Version = "v1",
                });
            });

            return services;
        }

        public static WebApplication UseApiServices(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapControllers();

            return app;
        }
    }
}
