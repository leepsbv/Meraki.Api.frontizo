﻿namespace Meraki.Api.Data;

/// <summary>
/// Rf Profiles By Device Meta
/// </summary>
[DataContract]
public class RfProfilesByDeviceMeta
{
	/// <summary>
	/// Count metadata related to this result set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public RfProfilesByDeviceMetaCounts Counts { get; set; } = new();

}
