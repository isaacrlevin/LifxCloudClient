using LifxCloud.NET.Infrastructure;
using LifxCloud.NET.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LifxCloud.NET
{
    public partial class LifxCloudClient
    {
        public async Task<Light> ListScenes()
        {
            return await GetResponseData<Light>($"{SceneEndPoint}");
        }

        public async Task<Light> GetScene(string selector)
        {
            return await GetResponseData<Light>($"{SceneEndPoint}{selector}");
        }

        public async Task<ApiResponse> ActivateScene(string scene_uuid, SetStateRequest request)
        {
            return await PutResponseData<ApiResponse>($"{SceneEndPoint}{scene_uuid}/activate", request);
        }
    }
}