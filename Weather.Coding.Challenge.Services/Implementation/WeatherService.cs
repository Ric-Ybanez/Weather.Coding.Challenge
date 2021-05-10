using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weather.Coding.Challenge.Services.Client;
using Weather.Coding.Challenge.Services.Model;

namespace Weather.Coding.Challenge.Services.Implementation
{
    public class WeatherService : IWeatherService
    {
        private readonly WeatherClient _client;
        private const string API_KEY = "128eb1b0ffa7ac7dbab9e6b93be43229";

        public WeatherService(WeatherClient client) => _client = client;

        public async Task<ServiceResponse> GetWeatherInfoByZipCodeAsync(string zipCode) 
        {
            var query = new Dictionary<string, string>
            {
                ["access_key"] = API_KEY,
                ["query"] = zipCode,
            };

            var response = await _client.GetAsync<WeatherAPIResponse>(QueryHelpers.AddQueryString("/current", query));

            if (response.Request == null)
                return null;

            return new ServiceResponse 
            { 
                IsCanFlyKite = response.Current.Wind_Speed > 15 && !response.Current.Weather_Descriptions.Any(a => a.ToLower().Contains("rain")),
                IsShouldGoOutSide = !response.Current.Weather_Descriptions.Any(a=> a.ToLower().Contains("rain")),
                IsShouldWearSunScreen = response.Current.Uv_Index > 3
            };
        }
    }
}
