﻿namespace Meraki.Api.Data;

/// <summary>
/// Pii response
/// </summary>
[DataContract]
public class PiiRequest : IdentifiedItem
{
	/// <summary>
	/// Organization wide
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationWide")]
	public bool OrganizationWide { get; set; }

	/// <summary>
	/// Network id
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// One of "delete" or "restrict processing"
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "type")]
	public PiiType Type { get; set; }

	/// <summary>
	/// The MAC of a network client device. Applies to both "restrict processing" and "delete" requests.
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The datasets related to the provided key that should be deleted. Only applies to "delete" requests. The value "all" will be expanded to all datasets applicable to this type. The datasets by applicable to each type are: mac (usage, events, traffic), email (users, loginAttempts), username (users, loginAttempts), bluetoothMac (client, connectivity), smDeviceId (device), smUserId (user)
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "datasets")]
	public List<string>? Datasets { get; set; } = [];

	/// <summary>
	/// Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Created at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// Completed at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "completedAt")]
	public DateTime CompletedAt { get; set; }
}
