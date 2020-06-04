using System;
using Lab9.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
namespace Lab9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context =
                    services.GetRequiredService<DatabaseContext>();
                    DbInitializer.Seed(context);
                }
                catch (Exception ex)
                {
                    var logger =
                    services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex,
                    "An error occurred while seeding the database.");
                }
            }
            host.Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });
    }
}
