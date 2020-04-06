using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class FlameEffectRequest
    {
        public double? period { get; set; } = 5;
        public double? duration { get; set; }
        public bool? power_on { get; set; } = true;
    }
}
