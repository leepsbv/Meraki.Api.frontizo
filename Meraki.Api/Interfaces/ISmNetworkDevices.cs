using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISmNetworkDevices
	{
		/// <summary>
		/// Wipe a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="wipeNetworkSmDevices">Body for wiping a device</param>
		[Post("/networks/{networkId}/sm/devices/wipe")]
		Task<WipeNetworkSmDevice> WipeNetworkSmDevicesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] WipeNetworkSmDevice wipeNetworkSmDevices,
			CancellationToken cancellationToken = default);
	}
}