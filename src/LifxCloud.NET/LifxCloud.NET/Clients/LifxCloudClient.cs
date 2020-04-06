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
        private static HttpClient _client { get; set; }

        private const string Url = "https://api.lifx.com/v1/";

        private string LightEndPoint = $"{Url}lights/";

        private string SceneEndPoint = $"{Url}scenes/";

        private string ColorEndPoint = $"{Url}color/";

        private LifxCloudClient()
        {
        }

        public static Task<LifxCloudClient> CreateAsync(string appToken)
        {
            LifxCloudClient client = new LifxCloudClient();
            client.Initialize(appToken);
            return Task.FromResult(client);
        }

        public void Initialize(string appToken)
        {
            RequestFactory _factory = new RequestFactory();
            _client = _factory.CreateClient(new AuthenticationHeaderValue("Bearer", appToken));

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
            appToken);
        }        

        public async Task<ColorResult> ValidateColor(string color)
        {
            return await GetResponseData<ColorResult>($"{ColorEndPoint}?string={color}");
        }

        internal static async Task<T> PutResponseData<T>(string url, object data)
        {
            return await await ResilientCall(async () =>
            {
                var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                var response = await _client.PutAsync(url, content);
                var result = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(result))
                {
                    throw new Exception("Something Bad Happened");
                }

                var resource = JsonConvert.DeserializeObject<T>(result);
                return resource;
            });
        }

        internal static async Task<T> PostResponseData<T>(string url, object data)
        {
            return await await ResilientCall(async () =>
            {
                var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(url, content);
                var result = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(result))
                {
                    throw new Exception("Something Bad Happened");
                }

                var resource = JsonConvert.DeserializeObject<T>(result);
                return resource;
            });
        }

        internal static async Task<T> GetResponseData<T>(String url)
        {
            return await await ResilientCall(async () =>
            {
                var response = await _client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(result))
                {
                    throw new Exception("Something Bad Happened");
                }

                var resource = JsonConvert.DeserializeObject<T>(result);
                return resource;
            });
        }

        async static Task<T> ResilientCall<T>(Func<T> block)
        {
            int currentRetry = 0;
            TimeSpan delay = TimeSpan.FromSeconds(2);

            for (; ; )
            {
                try
                {
                    return block();
                }
                catch (Exception ex)
                {
                    Trace.TraceError("Operation Exception");

                    currentRetry++;

                    // Check if the exception thrown was a transient exception
                    // based on the logic in the error detection strategy.
                    // Determine whether to retry the operation, as well as how
                    // long to wait, based on the retry strategy.
                    if (currentRetry > 3 || !IsTransient(ex))
                    {
                        // If this isn't a transient error or we shouldn't retry, 
                        // rethrow the exception.
                        throw;
                    }
                }

                // Wait to retry the operation.
                // Consider calculating an exponential delay here and
                // using a strategy best suited for the operation and fault.
                await Task.Delay(delay);
            }
        }

        private static bool IsTransient(Exception ex)
        {
            var webException = ex as WebException;
            if (webException != null)
            {
                // If the web exception contains one of the following status values
                // it might be transient.
                return new[] {WebExceptionStatus.ConnectionClosed,
                  WebExceptionStatus.Timeout,
                  WebExceptionStatus.RequestCanceled }.
                        Contains(webException.Status);
            }

            // Additional exception checking logic goes here.
            return false;
        }
    }
}
