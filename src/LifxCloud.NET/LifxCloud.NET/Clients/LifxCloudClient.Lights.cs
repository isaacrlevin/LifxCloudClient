using LifxCloud.NET.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LifxCloud.NET
{
   public partial class LifxCloudClient
    {
		public async Task<List<Light>> ListLights()
		{
			return await GetResponseData<List<Light>>($"{LightEndPoint}");
		}

		public async Task<Light> GetLight(string selector)
		{
			return await GetResponseData<Light>($"{LightEndPoint}{selector}");
		}

		public async Task<SetStateResponse> SetAllState(SetStateRequest request)
		{
			return (await SetState("all", request));
		}

		public async Task<SetStateResponse> SetState(string selector, SetStateRequest request)
		{
			return await PutResponseData<SetStateResponse>($"{LightEndPoint}{selector}/state", request);
		}

		public async Task<SetStateResponse> StateDelta(string selector, StateDeltaRequest request)
		{
			return await PostResponseData<SetStateResponse>($"{LightEndPoint}{selector}/state/delta", request);
		}

		public async Task<SetStateResponse> TogglePower(string selector, TogglePowerRequest request)
		{
			return await PostResponseData<SetStateResponse>($"{LightEndPoint}{selector}/state/toggle", request);
		}

		public async Task<SetStateResponse> BreathEffect(string selector, BreatheEffectRequest request)
		{
			return await PostResponseData<SetStateResponse>($"{LightEndPoint}{selector}/effects/breathe", request);
		}

		public async Task<SetStateResponse> MoveEffect(string selector, MoveEffectRequest request)
		{
			return await PostResponseData<SetStateResponse>($"{LightEndPoint}{selector}/effects/move", request);
		}

		public async Task<SetStateResponse> MorphEffect(string selector, MorphEffectRequest request)
		{
			return await PostResponseData<SetStateResponse>($"{LightEndPoint}{selector}/effects/morph", request);
		}

		public async Task<SetStateResponse> FlameEffect(string selector, FlameEffectRequest request)
		{
			return await PostResponseData<SetStateResponse>($"{LightEndPoint}{selector}/effects/flame", request);
		}

		public async Task<SetStateResponse> PulseEffect(string selector, PulseEffectRequest request)
		{
			return await PostResponseData<SetStateResponse>($"{LightEndPoint}{selector}/effects/pulse", request);
		}

		public async Task<SetStateResponse> EffectsOff(string selector, EffectsOffRequest request)
		{
			return await PostResponseData<SetStateResponse>($"{LightEndPoint}{selector}/effects/off", request);
		}

		public async Task<SetStateResponse> Cycle(string selector, CycleRequest request)
		{
			return await PostResponseData<SetStateResponse>($"{LightEndPoint}{selector}/cycle", request);
		}
	}
}
