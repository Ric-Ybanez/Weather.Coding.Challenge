using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Coding.Challenge.Services.Model
{
    public class Current
    {
        public string Observation_Time { get; set; }
        public double Temperature { get; set; }
        public double Weather_code { get; set; }
        public List<string> Weather_Icons { get; set; }
        public List<string> Weather_Descriptions { get; set; }
        public double Wind_Speed { get; set; }
        public double Wind_Degree { get; set; }
        public string Wind_Dir { get; set; }
        public double Pressure { get; set; }
        public double Precip { get; set; }
        public int Humidity { get; set; }
        public double Cloudcover { get; set; }
        public double FeelsLike { get; set; }
        public double Uv_Index { get; set; }
        public double Visibility { get; set; }
    }
}
