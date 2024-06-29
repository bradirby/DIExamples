using System.Text.Json;
using BlazorDIExamples.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorDIExamples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<ScopedService>();
            builder.Services.AddTransient<TransientService>();
            builder.Services.AddSingleton<SingletonService>();

            await builder.Build().RunAsync();
        }
    }
}
