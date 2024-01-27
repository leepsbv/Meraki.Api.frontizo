namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkWirelessSettings
/// </summary>
[DataContract]
public class WirelessSettingsUpdateDto
{
	/// <summary>
	/// Toggle for enabling or disabling meshing in a network
	/// </summary>
	/// <value>Toggle for enabling or disabling meshing in a network</value>
	[DataMember(Name = "meshingEnabled")]
	public bool? MeshingEnabled { get; set; }
	/// <summary>
	/// Toggle for enabling or disabling IPv6 bridging in a network (Note: if enabled, SSIDs must also be configured to use bridge mode)
	/// </summary>
	/// <value>Toggle for enabling or disabling IPv6 bridging in a network (Note: if enabled, SSIDs must also be configured to use bridge mode)</value>
	[DataMember(Name = "ipv6BridgeEnabled")]
	public bool? Ipv6BridgeEnabled { get; set; }
	/// <summary>
	/// Toggle for enabling or disabling location analytics for your network
	/// </summary>
	/// <value>Toggle for enabling or disabling location analytics for your network</value>
	[DataMember(Name = "locationAnalyticsEnabled")]
	public bool? LocationAnalyticsEnabled { get; set; }
	/// <summary>
	/// Toggle for enabling or disabling LED lights on all APs in the network (making them run dark)
	/// </summary>
	/// <value>Toggle for enabling or disabling LED lights on all APs in the network (making them run dark)</value>
	[DataMember(Name = "ledLightsOn")]
	public bool? LedLightsOn { get; set; }
	/// <summary>
	/// The upgrade strategy to apply to the network. Must be one of 'minimizeUpgradeTime' or 'minimizeClientDowntime'. Requires firmware version MR 26.8 or higher'
	/// </summary>
	[DataMember(Name = "upgradeStrategy")]
	public string? UpgradeStrategy { get; set; }
	/// <summary>
	/// Named VLAN settings for wireless networks.
	/// </summary>
	[DataMember(Name = "namedVlans")]
	public WirelessSettingsNamedVlans? NamedVlans { get; set; }
}
