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
        public async Task<List<Scene>> ListScenes()
        {
            var response = await GetResponseData<ApiResponse>($"{SceneEndPoint}");

            if (response.GetType() == typeof(ErrorResponse))
            {
                throw new Exception(((ErrorResponse)response).Error);
            }
            else
            {
                return (List<Scene>)response;
            }
        }

        public async Task<Scene> GetScene(string selector)
        {
            var response = await GetResponseData<ApiResponse>($"{SceneEndPoint}{selector}");

            if (response.GetType() == typeof(ErrorResponse))
            {
                throw new Exception(((ErrorResponse)response).Error);
            }
            else
            {
                return (Scene)response;
            }
        }

        public async Task<ApiResponse> ActivateScene(string scene_uuid, SetStateRequest request)
        {
            return await PutResponseData<ApiResponse>($"{SceneEndPoint}scene_id:{scene_uuid}/activate", request);
        }
    }
}