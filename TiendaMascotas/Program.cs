using Serilog;
using System.Reflection;
using TiendaMascotas;

namespace Administracion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args).UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
            host.ConfigureAppConfiguration((hostContext, config) =>
            {
                config.SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                config.AddJsonFile("appsettings.json", optional: true, false);
                config.AddEnvironmentVariables();
            });
            return host;
        }
    }
}
