using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class SetStateRequest
    {
        public string power { get; set; }
        public string color { get; set; }
        public double? brightness { get; set; }
        public double? duration { get; set; } = 1.0;
        public double? infrared { get; set; }
        public bool? fast { get; set; } = false;
    }
}
