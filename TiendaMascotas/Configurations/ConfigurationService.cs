using TiendaMascotas_Business.Services.Login;
using TiendaMascotas_Data.Models.Interfaces;

namespace TiendaMascotas.Configurations
{
    public static class ConfigurationService
    {
        public static IServiceCollection AddConfigurationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IInicioSesionService, InicioSesionServices>();

            return services;
        }

    }
}
