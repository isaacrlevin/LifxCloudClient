using LifxCloud.NET.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LifxCloud.NET.Console
{
    class Program
    {
        static async Task Main()
        {
            var client = await LifxCloudClient.CreateAsync("");

            var groups = await client.ListGroups(Selector.All);

            await groups.FirstOrDefault().SetState(
               new Models.SetStateRequest
               {
                   Power = PowerState.On,
                   Brightness = 1,
                   Duration = 1,
                   Color = LifxColor.Red
               });
        }
    }
}
