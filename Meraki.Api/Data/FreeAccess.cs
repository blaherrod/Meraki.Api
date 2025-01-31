﻿namespace Meraki.Api.Data;

/// <summary>
/// Free access
/// </summary>
[DataContract]
public class FreeAccess
{
	/// <summary>
	/// Duration in minutes
	/// </summary>
	[DataMember(Name = "durationInMinutes")]
	public int DurationInMinutes { get; set; }

	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
