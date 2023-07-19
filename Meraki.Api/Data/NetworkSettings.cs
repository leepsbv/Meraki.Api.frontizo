﻿namespace Meraki.Api.Data;

/// <summary>
/// Network settings
/// </summary>
[DataContract]
public class NetworkSettings
{
	/// <summary>
	/// Local status page enabled?
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "localStatusPageEnabled")]
	public bool? LocalStatusPageEnabled { get; set; }

	/// <summary>
	/// Remote status page enabled?
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "remoteStatusPageEnabled")]
	public bool? RemoteStatusPageEnabled { get; set; }

	/// <summary>
	/// Secure port settings - formerly secure connect
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "securePort")]
	public NetworkSettingsSecurePort? SecurePort { get; set; }

	/// <summary>
	/// Fips settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "fips")]
	public NetworkSettingsFips? Fips { get; set; }

	/// <summary>
	/// Local Status PAge
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "localStatusPage")]
	public LocalStatusPage? LocalStatusPage { get; set; }

	/// <summary>
	/// Client Privacy
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "clientPrivacy")]
	public NetworkSettingsClientPrivacy? ClientPrivacy { get; set; }

	/// <summary>
	/// A hash of Named VLANs options applied to the Network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "namedVlans")]
	public NetworkSettingsNamedVlans? NamedVlans { get; set; }
}
