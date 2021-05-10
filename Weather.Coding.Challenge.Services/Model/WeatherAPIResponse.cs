using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Coding.Challenge.Services.Model
{
    public class WeatherAPIResponse
    {
        public Request Request { get; set; }
        public Location Location { get; set; }
        public Current Current { get; set; }
    }
}
