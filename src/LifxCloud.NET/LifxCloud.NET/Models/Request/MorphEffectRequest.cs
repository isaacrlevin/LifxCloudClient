using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class MorphEffectRequest
    {
        [JsonProperty("period")]
        public double? Period { get; set; } = 5;
        [JsonProperty("duration")]
        public double? Duration { get; set; }
        [JsonProperty("power_on")]
        public bool? PowerOn { get; set; } = true;
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        [JsonProperty("palette")]
        public List<string>? Palette { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    }
}
