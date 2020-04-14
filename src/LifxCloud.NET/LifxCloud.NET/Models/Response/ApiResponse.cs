using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class ApiResponse
    {
    }

    public class SuccessResponse : ApiResponse
    {
        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }

    public class Result
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("label")]
        public string Label { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }

        public bool IsSuccessful { get { return Status == "ok"; } }

        public bool IsTimedOut { get { return Status == "timed_out"; } }
    }

    public class ErrorResponse : ApiResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("errors")]
        public List<Error> Errors { get; set; }
    }

    public class Error
    {
        [JsonProperty("field")]
        public string Field { get; set; }
        [JsonProperty("message")]
        public string[] Message { get; set; }
    }
}