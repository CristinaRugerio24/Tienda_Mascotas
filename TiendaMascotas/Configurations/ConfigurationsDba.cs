using Microsoft.EntityFrameworkCore;


namespace TiendaMascotas.Configurations
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddConfigurationDba(this IServiceCollection services, IConfiguration configuration)
        {
            // Registrar el DbContext
            services.AddDbContext<TiendaMascotasDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
