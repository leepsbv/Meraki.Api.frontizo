﻿namespace Meraki.Api.Data;

/// <summary>
/// Traffic and Distribution
/// </summary>
[DataContract]
public class TrafficAndDistribution
{
	/// <summary>
	/// rawDistribution
	/// </summary>
	[DataMember(Name = "rawDistribution")]
	public Dictionary<string, long> RawDistribution { get; set; }
		= [];

	/// <summary>
	/// avg
	/// </summary>
	[DataMember(Name = "avg")]
	public double Average { get; set; }
}
