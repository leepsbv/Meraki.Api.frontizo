﻿namespace Meraki.Api.Interfaces.Products.Sensor;

public interface IOrganizationSensorRelationships
{
	/// <summary>
	/// List the sensor roles for a given sensor or camera device.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The device serial</param>
	[ApiOperationId("getDeviceSensorRelationships")]
	[Get("/devices/{serial}/sensor/relationships")]
	Task<List<SensorRelationship>> GetDeviceSensorRelationshipsAsync(
		string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the sensor roles for devices in a given network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSensorRelationships")]
	[Get("/networks/{networkId}/sensor/relationships")]
	Task<List<NetworkSensorRelationship>> GetNetworkSensorRelationshipsAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Assign one or more sensor roles to a given sensor or camera device.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The device serial</param>
	/// <param name="sensorRelationshipUpdateRequest">Body for updating a sensor role</param>
	[ApiOperationId("updateDeviceSensorRelationships")]
	[Put("/devices/{serial}/sensor/relationships")]
	Task<SensorRelationship> UpdateDeviceSensorRelationshipsAsync(
		string serial,
		[Body] SensorRelationship sensorRelationshipUpdateRequest,
		CancellationToken cancellationToken = default
		);
}
