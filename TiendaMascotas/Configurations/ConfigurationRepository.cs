using TiendaMascotas_Data.Models.Interfaces;
using TiendaMascotas_Entities.Repositories;

namespace TiendaMascotas.Configurations
{
    public static class ConfigurationRepository
    {
        public static IServiceCollection AddConfigurationRepositories(this IServiceCollection services)
        {
           
            services.AddScoped<ITiendaRepository, TiendaRepository>();
            return services;
        }
    }
}
