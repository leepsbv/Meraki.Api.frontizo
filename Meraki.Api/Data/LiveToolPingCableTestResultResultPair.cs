﻿namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Cable Test ResultResult Pair
/// </summary>
[DataContract]

public class LiveToolsCableTestResultResultPair
{
	/// <summary>
	/// The index of the twisted pair tested.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "index")]
	public int Index { get; set; }

	/// <summary>
	/// The detected length of the twisted pair.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lengthMeters")]
	public int LengthMeters { get; set; }

	/// <summary>
	/// The test result of the twisted pair tested.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}
