﻿namespace Meraki.Api.Interfaces.General.LiveTools;

public interface ILiveToolsArpTable
{
	/// <summary>
	/// Enqueue a job to perform a ARP table request for the device. This endpoint currently supports switches.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="createDeviceLiveToolsArpTable">Body</param>
	[ApiOperationId("createDeviceLiveToolsArpTable")]
	[Post("/devices/{serial}/liveTools/arpTable")]
	Task<LiveToolsArpTable> CreateDeviceLiveToolsArpTableAsync(
		string serial,
		[Body] LiveToolsArpTableCreate createDeviceArpTable,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return an ARP table live tool job.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="arpTableId">Arp table ID</param>
	[ApiOperationId("getDeviceLiveToolsArpTable")]
	[Get("/devices/{serial}/liveTools/wakeOnLan/{wakeOnLanId}")]
	Task<LiveToolsArpTableResult> GetDeviceLiveToolsArpTableAsync(
		string serial,
		string arpTableId,
		CancellationToken cancellationToken = default);
}
