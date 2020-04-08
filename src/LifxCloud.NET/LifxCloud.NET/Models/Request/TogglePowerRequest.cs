using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class TogglePowerRequest
    {
        [JsonProperty("duration")]
        public double? Duration { get; set; } = 1.0;
    }
}
