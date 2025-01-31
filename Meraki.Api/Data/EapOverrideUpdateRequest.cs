﻿namespace Meraki.Api.Data;

/// <summary>
/// Update the EAP overridden parameters for an SSID
/// </summary>
[DataContract]
public class EapOverrideUpdateRequest
{
	/// <summary>
	/// General EAP timeout in seconds.
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "maxRetries")]
	public int MaxRetries { get; set; }

	/// <summary>
	/// Maximum number of general EAP retries
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "timeout")]
	public int Timeout { get; set; }

	/// <summary>
	/// EAPOL Key settings.
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "eapolKey")]
	public EapolKey EapolKey { get; set; } = new();

	/// <summary>
	/// EAP settings for identity requests.
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "identity")]
	public EapolIdentity Identity { get; set; } = new();
}
