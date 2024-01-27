namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkCellularFirewallRules
/// </summary>
[DataContract]
public class CellularFirewallRules
{
	/// <summary>
	/// An ordered array of the firewall rules (not including the default rule)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<MxFirewallRule> Rules { get; set; } = [];
}
