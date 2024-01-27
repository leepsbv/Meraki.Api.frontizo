﻿namespace Meraki.Api.Data;

[DataContract]
public class IpRestrictionsForKeys
{
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ranges")]
	public List<string> Ranges { get; set; } = [];
}
