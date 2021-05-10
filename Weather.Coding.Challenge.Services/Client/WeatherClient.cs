using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Coding.Challenge.Services.Client
{
    public class WeatherClient
    {
        private readonly HttpClient _client;
        public WeatherClient(HttpClient? client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<Response> GetAsync<Response>(string requestUri)
        {
            try
            {
                var response = await _client.GetAsync(requestUri);
                var content = await response.Content.ReadFromJsonAsync<Response>();
                return content!;
            }
            catch (Exception aex)
            {
                throw;
            }
        }
    }
}
