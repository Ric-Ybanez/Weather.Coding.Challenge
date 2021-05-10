using System;
using System.Threading.Tasks;
using Weather.Coding.Challenge.Services;
using Weather.Coding.Challenge.Services.Model;

namespace Weather.Coding.Challenge
{
    class App
    {
        private readonly IWeatherService _service;
        public App(IWeatherService service)
        {
            _service = service;
        }

        public async Task RunAsync()
        {
            string zipCode = ConsoleWriter.ReadZipCode();

            var response = await _service.GetWeatherInfoByZipCodeAsync(zipCode);

            ConsoleWriter.PrintOutput(response);

            ConsoleWriter.ExitApplication();
        }
    }
}
