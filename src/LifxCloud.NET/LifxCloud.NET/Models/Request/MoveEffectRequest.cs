using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class MoveEffectRequest
    {
        public string direction { get; set; } = "forward";
        public double? period { get; set; } = 1;
        public double? cycles { get; set; }
        public bool? power_on { get; set; } = true;
    }
}
