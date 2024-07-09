﻿namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Cable Test
/// </summary>
[DataContract]

public class LiveToolsCableTest
{
	/// <summary>
	/// Id of the cable test request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "cableTestId")]
	public string CableTestId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the cable test request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your cable test request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public LiveToolsCableTestCallback Callback { get; set; } = new();

	/// <summary>
	/// Cable test request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public LiveToolsCableTestRequest Request { get; set; } = new();
}
