using LifxCloud.NET.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LifxCloud.NET.Clients
{
    public interface ILightTarget<ResponseType>
    {
        string Id { get; }
        string Label { get; }
        bool IsOn { get; }

        public Task<ApiResponse> TogglePower(TogglePowerRequest request);

        public Task<ApiResponse> SetState(SetStateRequest request);
    }
}
