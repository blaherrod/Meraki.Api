﻿namespace Meraki.Api.Data;

/// <summary>
/// The current setting for 802.11r
/// </summary>
[DataContract]
public class Dot11r
{
	/// <summary>
	/// (Optional) Whether 802.11r is adaptive or not.
	/// </summary>
	[DataMember(Name = "adaptive")]
	public bool? Adaptive { get; set; }

	/// <summary>
	/// Whether 802.11r is enabled or not.
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
