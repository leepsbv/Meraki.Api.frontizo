namespace Meraki.Api.Data;

/// <summary>
/// The Bonjour settings for your group policy. Only valid if your network has a wireless configuration.
/// </summary>
[DataContract]
public class BonjourForwarding
{
	/// <summary>
	/// If true, Bonjour forwarding is enabled on this SSID.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// A list of the Bonjour forwarding rules for your group policy. If 'settings' is set to 'custom', at least one rule must be specified.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<BonjourForwardingRule> Rules { get; set; } = new();
}
