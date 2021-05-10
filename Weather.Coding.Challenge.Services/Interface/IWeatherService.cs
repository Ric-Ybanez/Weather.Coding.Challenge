using System;
using System.Threading.Tasks;

namespace Weather.Coding.Challenge.Services
{
    public interface IWeatherService
    {
        Task<ServiceResponse> GetWeatherInfoByZipCodeAsync(string zipCode);
    }
}