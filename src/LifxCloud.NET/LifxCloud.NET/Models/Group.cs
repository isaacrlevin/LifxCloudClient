using LifxCloud.NET.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public sealed class Group : LightCollection
    {
        public Group(LifxCloudClient client, string id, string label, List<Light> lights)
            : base(client, id, label, lights) { }

        public override Selector ToSelector()
        {
            return new Selector.GroupId(Id);
        }
    }
}
