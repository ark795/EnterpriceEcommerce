using Microsoft.Extensions.Hosting;         // ✅ ضروری
using Microsoft.Extensions.Configuration;   // برای context.Configuration
using Serilog;

namespace BuildingBlocks.Logging;

public static class SerilogConfiguration
{
    public static void ConfigureSerilog(this IHostBuilder hostBuilder)
    {
        hostBuilder.UseSerilog((context, configuration) =>
        {
            configuration
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.Seq("http://localhost:5341") // بهتره این رو از appsettings بگیریم
                .ReadFrom.Configuration(context.Configuration);
        });
    }
}