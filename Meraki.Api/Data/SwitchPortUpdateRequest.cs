﻿namespace Meraki.Api.Data;

/// <summary>
/// A device switch port update request
/// </summary>
[DataContract]
public class SwitchPortUpdateRequest
{
	/// <summary>
	/// The number of a custom access policy to configure on the switch port. Only applicable when 'accessPolicyType' is 'Custom access policy'
	/// </summary>
	[DataMember(Name = "accessPolicyNumber")]
	public int? AccessPolicyNumber { get; set; }

	/// <summary>
	/// The maximum number of MAC addresses for sticky MAC allow list. Only applicable when 'accessPolicyType' is 'Sticky MAC allow list'
	/// </summary>
	[DataMember(Name = "stickyMacAllowListLimit")]
	public int? StickyMacAllowListLimit { get; set; }

	/// <summary>
	/// The VLAN of the switch port. A null value will clear the value set for trunk ports.
	/// </summary>
	[DataMember(Name = "vlan")]
	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	public int? Vlan { get; set; }

	/// <summary>
	/// The voice VLAN of the switch port. Only applicable to access ports.
	/// </summary>
	[DataMember(Name = "voiceVlan")]
	public int? VoiceVlan { get; set; }

	/// <summary>
	/// The type of the access policy of the switch port. Only applicable to access ports. Can be one of 'Open', 'Custom access policy', 'MAC allow list' or 'Sticky MAC allow list'
	/// </summary>
	[DataMember(Name = "accessPolicyType")]
	public string? AccessPolicyType { get; set; }

	/// <summary>
	/// The adaptive policy group ID that will be used to tag traffic through this switch port. This ID must pre-exist during the configuration, else needs to be created using adaptivePolicy/groups API. Cannot be applied to a port on a switch bound to profile.
	/// </summary>
	[DataMember(Name = "adaptivePolicyGroupId")]
	public string? AdaptivePolicyGroupId { get; set; }

	/// <summary>
	/// The VLANs allowed on the switch port. Only applicable to trunk ports.
	/// </summary>
	[DataMember(Name = "allowedVlans")]
	public string? AllowedVlans { get; set; }

	/// <summary>
	/// The link speed for the switch port
	/// </summary>
	[DataMember(Name = "linkNegotiation")]
	public string? LinkNegotiation { get; set; }

	/// <summary>
	/// Port Name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The ID of the port schedule. A value of null will clear the port schedule
	/// </summary>
	[DataMember(Name = "portScheduleId")]
	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	public string? PortScheduleId { get; set; }

	/// <summary>
	/// The state of the STP guard ('disabled', 'root guard', 'bpdu guard' or 'loop guard')
	/// </summary>
	[DataMember(Name = "stpGuard")]
	public string? StpGuard { get; set; }

	/// <summary>
	/// The type of the switch port ('trunk' or 'access')
	/// </summary>
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// The action to take when Unidirectional Link is detected (Alert only, Enforce). Default configuration is Alert only.
	/// </summary>
	[DataMember(Name = "udld")]
	public string? Udld { get; set; }

	/// <summary>
	/// If true, ARP packets for this port will be considered trusted, and Dynamic ARP Inspection will allow the traffic.
	/// </summary>
	[DataMember(Name = "daiTrusted")]
	public bool? DaiTrusted { get; set; }

	/// <summary>
	/// The status of the switch port
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// For supported switches (e.g. MS420/MS425), whether or not the port has flexible stacking enabled.
	/// </summary>
	[DataMember(Name = "flexibleStackingEnabled")]
	public bool? FlexibleStackingEnabled { get; set; }

	/// <summary>
	/// The isolation status of the switch port
	/// </summary>
	[DataMember(Name = "isolationEnabled")]
	public bool? IsolationEnabled { get; set; }

	/// <summary>
	/// If true, Peer SGT is enabled for traffic through this switch port. Applicable to trunk port only, not access port. Cannot be applied to a port on a switch bound to profile.
	/// </summary>
	[DataMember(Name = "peerSgtCapable")]
	public bool? PeerSgtCapable { get; set; }

	/// <summary>
	/// The PoE status of the switch port
	/// </summary>
	[DataMember(Name = "poeEnabled")]
	public bool? PoeEnabled { get; set; }

	/// <summary>
	/// The rapid spanning tree protocol status
	/// </summary>
	[DataMember(Name = "rstpEnabled")]
	public bool? RstpEnabled { get; set; }

	/// <summary>
	/// The storm control status of the switch port
	/// </summary>
	[DataMember(Name = "stormControlEnabled")]
	public bool? StormControlEnabled { get; set; }

	/// <summary>
	/// Only devices with MAC addresses specified in this list will have access to this port. 
	/// Up to 20 MAC addresses can be defined. Only applicable when 'accessPolicyType' is 'MAC allow list'.
	/// </summary>
	[DataMember(Name = "macAllowList")]
	public List<string>? MacAllowList { get; set; }

	/// <summary>
	/// The initial list of MAC addresses for sticky Mac allow list. Only applicable when 'accessPolicyType' is 'Sticky MAC allow list'
	/// </summary>
	[DataMember(Name = "stickyMacAllowList")]
	public List<string>? StickyMacAllowList { get; set; }

	/// <summary>
	/// The list of tags of the switch port
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }

	/// <summary>
	/// dot3az settings for the port
	/// </summary>
	[DataMember(Name = "dot3az")]
	public SwitchPortDot3az? Dot3az { get; set; }

	/// <summary>
	/// Profile attributes
	/// </summary>
	[DataMember(Name = "profile")]
	public SwitchPortProfile? Profile { get; set; }
}
