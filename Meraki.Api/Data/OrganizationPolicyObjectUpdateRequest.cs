﻿namespace Meraki.Api.Data;

/// <summary>
/// Organizaton Policy Object Update Request
/// </summary>
[DataContract]

public class OrganizationPolicyObjectUpdateRequest : NamedItem
{
	/// <summary>
	/// CIDR Value of a policy object (e.g. 10.11.12.1/24)
	/// </summary>
	[DataMember(Name = "cidr")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Cidr { get; set; }

	/// <summary>
	/// Fully qualified domain name of policy object (e.g. "example.com")
	/// </summary>
	[DataMember(Name = "fqdn")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Fqdn { get; set; }

	/// <summary>
	/// IP Address of a policy object (e.g. "1.2.3.4")
	/// </summary>
	[DataMember(Name = "ip")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Ip { get; set; }

	/// <summary>
	/// Mask of a policy object (e.g. "255.255.0.0")
	/// </summary>
	[DataMember(Name = "mask")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Mask { get; set; }

	/// <summary>
	/// The IDs of policy object groups the policy object belongs to
	/// </summary>
	[DataMember(Name = "groupIds")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<string>? GroupIds { get; set; }

	/// <summary>
	/// Networkd Ids
	/// </summary>
	[DataMember(Name = "networkIds")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<string>? NetworkIds { get; set; }
}