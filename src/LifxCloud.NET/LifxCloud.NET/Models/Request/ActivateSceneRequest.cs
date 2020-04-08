using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class ActivateSceneRequest
    {
        [JsonProperty("duration")]
        public double? duration { get; set; } = 1.0;
        [JsonProperty("ignore")]
        public List<string> Ignore { get; set; }
        [JsonProperty("overrides")]
        public SetStateRequest Overrides { get; set; }
        [JsonProperty("fast")]
        public bool? Fast { get; set; }
    }
}
