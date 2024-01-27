﻿namespace Meraki.Api.Data;

/// <summary>
/// An API usage overview
/// </summary>
[DataContract]
public class ApiUsageOverview
{
	/// <summary>
	/// The stats
	/// </summary>
	[DataMember(Name = "responseCodeCounts")]
	public Dictionary<string, int> ResponseCodeCounts { get; set; } = [];
}
