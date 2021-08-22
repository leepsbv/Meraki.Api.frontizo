using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMgUplinkSettings
	{
		/// <summary>
		/// Returns the uplink settings for your MG network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/cellularGateway/settings/uplink")]
		Task<NetworkCellularGatewaySettingsUplinkUpdateRequest> GetNetworkCellularGatewaySettingsUplinkAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Updates the uplink settings for your MG network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkCellularGatewaySettingsUplink">Body for updating uplink settings</param>
		[Put("/networks/{networkId}/cellularGateway/settings/uplink")]
		Task<NetworkCellularGatewaySettingsUplinkUpdateRequest> UpdateNetworkCellularGatewaySettingsUplinkAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkCellularGatewaySettingsUplinkUpdateRequest updateNetworkCellularGatewaySettingsUplink,
			CancellationToken cancellationToken = default
			);
	}
}
