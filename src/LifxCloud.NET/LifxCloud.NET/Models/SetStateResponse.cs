using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class SetStateResponse
    {
        public List<Result> results { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string label { get; set; }
        public string status { get; set; }
    }
}