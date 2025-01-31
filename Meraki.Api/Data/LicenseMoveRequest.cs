namespace Meraki.Api.Data;

/// <summary>
/// MoveOrganizationLicenses
/// </summary>
[DataContract]
public class LicenseMoveRequest
{
	/// <summary>
	/// The ID of the organization to move the licenses to
	/// </summary>
	/// <value>The ID of the organization to move the licenses to</value>
	[DataMember(Name = "destOrganizationId")]
	public string DestinationOrganizationId { get; set; } = null!;

	/// <summary>
	/// A list of IDs of licenses to move to the new organization
	/// </summary>
	/// <value>A list of IDs of licenses to move to the new organization</value>
	[DataMember(Name = "licenseIds")]
	public List<string> LicenseIds { get; set; } = null!;
}
