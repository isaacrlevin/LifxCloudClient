using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class ActivateScene
    {
        public double? duration { get; set; } = 1.0;

        public List<string> ignore { get; set; }
        public SetStateRequest overrides { get; set; }
        public bool? fast { get; set; }
       
    }
}
