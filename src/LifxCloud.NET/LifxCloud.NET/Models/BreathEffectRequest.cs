﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class BreatheEffectRequest
    {
        public string color { get; set; }
        public string from_color { get; set; }
        public double? period { get; set; } = 1.0;
        public double? cycles { get; set; } = 1.0;
        public double? peak { get; set; } = .5;
        public bool? persist { get; set; } = false;
        public bool? power_on { get; set; } = true;
    }
}
