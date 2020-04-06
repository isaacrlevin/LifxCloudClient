using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class Light
    {
        public string id { get; set; }
        public string uuid { get; set; }
        public string label { get; set; }
        public bool connected { get; set; }
        public string power { get; set; }
        public Color color { get; set; }
        public float brightness { get; set; }
        public string effect { get; set; }
        public Group group { get; set; }
        public Location location { get; set; }
        public Product product { get; set; }
        public DateTime last_seen { get; set; }
        public int seconds_since_seen { get; set; }
    }

    public class Color
    {
        public double hue { get; set; }
        public double saturation { get; set; }
        public double kelvin { get; set; }
    }

    public class Group
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Location
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Product
    {
        public string name { get; set; }
        public string identifier { get; set; }
        public string company { get; set; }
        public Capabilities capabilities { get; set; }
    }

    public class Capabilities
    {
        public bool has_color { get; set; }
        public bool has_variable_color_temp { get; set; }
        public bool has_ir { get; set; }
        public bool has_chain { get; set; }
        public bool has_multizone { get; set; }
        public double min_kelvin { get; set; }
        public double max_kelvin { get; set; }
    }
}
