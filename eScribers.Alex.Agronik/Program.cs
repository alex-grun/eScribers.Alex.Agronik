using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace eScribers.Alex.Agronik
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://*:47890");
                    webBuilder.UseStartup<Startup>();
                })
                .UseWindowsService()
                .UseSystemd();
    }
}
