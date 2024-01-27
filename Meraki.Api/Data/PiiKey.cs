﻿namespace Meraki.Api.Data;

/// <summary>
/// Pii Key
/// </summary>
[DataContract]
public class PiiKey
{
	/// <summary>
	/// The MAC of a network client device or a Systems Manager device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "macs")]
	public List<string> Macs { get; set; } = [];

	/// <summary>
	/// The email of a network user account or a Systems Manager device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "emails")]
	public List<string> Emails { get; set; } = [];

	/// <summary>
	/// The username of a Systems Manager user
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "usernames")]
	public List<string> Usernames { get; set; } = [];

	/// <summary>
	/// The serial of a Systems Manager device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = [];

	/// <summary>
	/// The IMEI of a Systems Manager device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "imeis")]
	public List<string> Imeis { get; set; } = [];

	/// <summary>
	/// The MAC of a Bluetooth client
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "bluetoothMacs")]
	public List<string> BluetoothMacs { get; set; } = [];
}
