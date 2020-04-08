using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models.Response
{
    public sealed class Location : LightCollection
    {
        public Location(LifxCloudClient client, string id, string label, List<Light> lights)
            : base(client, id, label, lights) { }

        public override Selector ToSelector()
        {
            return new Selector.LocationId(Id);
        }
    }
}
