# LifxCloudClient

A .NET Standard 2.0 library for LIFX Cloud-enabled lights.
Supports .NET, UWP, Xamarin iOS, Xamarin Android, and any other .NET Platform that has implemented .NET Standard 2.0+.

For LAN Protocol based implementation, check out [dotMorten's repo](https://github.com/dotMorten/LifxNet)


Based on the official [LIFX HTTP API](https://lifx.readme.io/docs)

####Usage

Obtain Access Token from [Cloud Settings](https://cloud.lifx.com/settings)

```csharp
var client = await LifxCloudClient.CreateAsync("YOUR TOKEN");

Console.WriteLine("Getting Lights");
var lights = await client.ListLights();

Console.WriteLine("Setting State");
var result = await client.SetState(lights.FirstOrDefault().id,
    new Models.SetStateRequest
    {
        power = PowerState.On,
        brightness = 1,
        duration = 1,
        color = "yellow saturation:1"
    });

```

