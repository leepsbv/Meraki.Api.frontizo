﻿namespace Meraki.Api.Interfaces.General.Devices;
public interface IDeviceWirelessElectronicShelfLabel
{
	/// <summary>
	/// Return the ESL settings of a device
	/// </summary>
	/// <param name="serial">Serial</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceWirelessElectronicShelfLabel")]
	[Get("/devices/{serial}/wireless/electronicShelfLabel")]
	Task<ElectronicShelfLabelSettings> GetDeviceWirelessElectronicShelfLabelAsync(
		string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the ESL settings of a device
	/// </summary>
	/// <param name="serial">Serial</param>
	/// <param name="settings">Update Settings</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateDeviceWirelessElectronicShelfLabel")]
	[Put("/devices/{serial}/wireless/electronicShelfLabel")]
	Task<ElectronicShelfLabelSettings> UpdateDeviceWirelessElectronicShelfLabelAsync(
		string serial,
		[Body] ElectronicShelfLabelSettingsUpdate settings,
		CancellationToken cancellationToken = default);
}
