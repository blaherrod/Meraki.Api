﻿namespace Meraki.Api.Data;

/// <summary>
/// Events
/// </summary>
[DataContract]
public class NetworkEvents
{
	/// <summary>
	/// Page start at
	/// </summary>
	[DataMember(Name = "pageStartAt")]
	public string PageStartAt { get; set; } = string.Empty;

	/// <summary>
	/// Page end at
	/// </summary>
	[DataMember(Name = "pageEndAt")]
	public string PageEndAt { get; set; } = string.Empty;

	/// <summary>
	/// Events
	/// </summary>
	[DataMember(Name = "events")]
	public List<Events> Events { get; set; } = new();
}
