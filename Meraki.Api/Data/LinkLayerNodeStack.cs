﻿namespace Meraki.Api.Data;
/// <summary>
/// Stack
/// </summary>
[DataContract]
public class LinkLayerNodeStack
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public int Id { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Members
	/// </summary>
	[DataMember(Name = "members")]
	public List<LinkLayerNodeStackMember> Members { get; set; } = [];

	/// <summary>
	/// Clients
	/// </summary>
	[DataMember(Name = "clients")]
	public StackDeviceClients Clients { get; set; } = new();
}
