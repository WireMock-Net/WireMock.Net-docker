using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace dotnet_web_example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                    // .ConfigureLogging(factory => factory.AddConsole(LogLevel.None))
                    .Configure(appBuilder =>
                    {
                        // appBuilder.UseExceptionHandler(builder => )
                        // appBuilder.Use<WireMockMiddleware>();
                        // appBuilder.Run(async (context, env) =>
                        // {
                        //     await context.Response.WriteAsync("Hello World!");
                        // });

                        
                    })
                    .UseStartup<Startup>()
                    .UseKestrel()
                    .UseUrls(new [] {"http://*:5000"})
                    .Build();

                host.RunAsync().Wait();

            //BuildWebHost(args).Run();
        }

        // public static IWebHost BuildWebHost(string[] args) =>
        //     WebHost.CreateDefaultBuilder(args)
        //         .UseStartup<Startup>()
        //         .UseUrls("http://*:80")
        //         .Build();
    }
}
