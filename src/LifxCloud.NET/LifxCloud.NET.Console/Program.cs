using System;
using System.Linq;
using System.Threading.Tasks;

namespace LifxCloud.NET.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = await LifxCloudClient.CreateAsync("");

            System.Console.WriteLine("Getting Lights");
            var lights = await client.ListLights();


            System.Console.WriteLine("Setting State");
            var foo = await client.SetState(lights.FirstOrDefault().id,
                new Models.SetStateRequest
                {
                    power = "on",
                    brightness = 1,
                    duration = 1,
                    color = "yellow saturation:1"
                });
        }
    }
}
