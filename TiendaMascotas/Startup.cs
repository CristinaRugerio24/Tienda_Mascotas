using Serilog.Events;
using Serilog;
using System.Text.Json.Serialization;
using TiendaMascotas.Configurations;


namespace TiendaMascotas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
            //Swagger
            //services.AddConfigurationSwagger(Configuration);
            //Dba
            services.AddConfigurationDba(Configuration);
            services.AddConfigurationRepositories();

            services.AddConfigurationServices(Configuration);
            services.AddHttpContextAccessor();
            //services.AddConfigurationHttpClients(Configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            Log.Logger = new LoggerConfiguration()
              .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
              .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Information)
              .MinimumLevel.Override("System", LogEventLevel.Information)
             .Enrich.FromLogContext()
            //.WriteTo.Console(LogEventLevel.Information).CreateLogger();
            .WriteTo.File(Path.Combine(
                Configuration.GetSection("AppSettings")
               .GetSection("PathApiLog").Value, "Administracion.log"), rollingInterval: RollingInterval.Day).CreateLogger();
            app.UseHttpsRedirection();
            app.UseRouting();
            loggerFactory.AddSerilog();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }
    


}