namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkPortForwardingRules
/// </summary>
[DataContract]
public class PortForwardingRules
{
	/// <summary>
	/// An array of port forwarding params
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<PortForwardingRule> Rules { get; set; } = [];
}
