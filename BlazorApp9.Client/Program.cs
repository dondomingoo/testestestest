using System.Net.Http;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp9.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddScoped<HttpClient>(sp =>
            {
                var client = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
                Console.WriteLine($" HttpClient registreret med BaseAddress: {client.BaseAddress}");
                return client;
            });

            await builder.Build().RunAsync();
        }
    }
}
