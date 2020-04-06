using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class CycleRequest
    {
        public List<SetStateRequest> states { get; set; }

        public SetStateRequest defaults { get; set; }

        public string direction { get; set; } = "forward";       
    }
}
