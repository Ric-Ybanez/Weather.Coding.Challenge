using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Coding.Challenge.Services
{
    public class ServiceResponse
    {
        public bool IsShouldGoOutSide { get; set; } = false;
        public bool IsShouldWearSunScreen { get; set; } = false;
        public bool IsCanFlyKite { get; set; } = false;
    }
}
