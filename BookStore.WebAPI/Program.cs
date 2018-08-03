using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;

namespace BookStore.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseSerilog((ctx, cfg) =>
            {
                cfg.ReadFrom.Configuration(ctx.Configuration)
                    .MinimumLevel.Error()
                    .Enrich.WithMachineName()
                    .Enrich.WithEnvironmentUserName()
                    .MinimumLevel.Override("Microsoft", LogEventLevel.Error)
                    .WriteTo.RollingFile("Logs\\BookStore-{Date}.log", restrictedToMinimumLevel: LogEventLevel.Error, outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} {Level:u3}] {SourceContext}: {Message:lj}{NewLine}{Exception}");
            })
            .ConfigureLogging(logging => logging.AddFilter("System", LogLevel.Error))
            .UseStartup<Startup>();
    }
}
