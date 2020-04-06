using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class Scene
    {
        public string uuid { get; set; }
        public string name { get; set; }
        public Account account { get; set; }
        public List<State> states { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
    }

    public class Account
    {
        public string uuid { get; set; }
    }

    public class State
    {
        public float brightness { get; set; }
        public string selector { get; set; }
        public Color color { get; set; }
    }
}
