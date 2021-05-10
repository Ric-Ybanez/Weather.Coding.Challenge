using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Coding.Challenge.Services.Model
{
    public class Location
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Timezone_id { get; set; }
        public string Localtime { get; set; }
        public int Localtime_Epoch { get; set; }
        public string Utc_Offset { get; set; }
    }
}
