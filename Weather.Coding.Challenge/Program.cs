using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Weather.Coding.Challenge.Services;
using Weather.Coding.Challenge.Services.Client;
using Weather.Coding.Challenge.Services.Implementation;

namespace Weather.Coding.Challenge
{
    class Program
    {
        public static async Task Main(string[] args) =>
            await ConfigureServices(args).
                  GetService<App>()!.
                  RunAsync();

        private static ServiceProvider ConfigureServices(string[] args)
        {
            var serviceColl = new ServiceCollection();

            serviceColl.AddHttpClient<WeatherClient>(c => c.BaseAddress = new System.Uri("http://api.weatherstack.com"));

            // Services
            serviceColl.AddTransient<IWeatherService, WeatherService>();

            // Main App
            serviceColl.AddTransient<App>();

            return serviceColl.BuildServiceProvider();
        }
    }

}
