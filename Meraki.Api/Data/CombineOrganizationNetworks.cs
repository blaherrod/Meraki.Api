namespace Meraki.Api.Data;

/// <summary>
/// CombineOrganizationNetworks
/// </summary>
[DataContract]
public class CombineOrganizationNetworksRequest
{
	/// <summary>
	/// The name of the combined network
	/// </summary>
	/// <value>The name of the combined network</value>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
	/// <summary>
	/// A list of the network IDs that will be combined. If an ID of a combined network is included in this list, the other networks in the list will be grouped into that network
	/// </summary>
	/// <value>A list of the network IDs that will be combined. If an ID of a combined network is included in this list, the other networks in the list will be grouped into that network</value>
	[DataMember(Name = "networkIds")]
	public List<string> NetworkIds { get; set; } = new();
	/// <summary>
	/// A unique identifier which can be used for device enrollment or easy access through the Meraki SM Registration page or the Self Service Portal. Please note that changing this field may cause existing bookmarks to break. All networks that are part of this combined network will have their enrollment string appended by '-network_type'. If left empty, all exisitng enrollment strings will be deleted.
	/// </summary>
	/// <value>A unique identifier which can be used for device enrollment or easy access through the Meraki SM Registration page or the Self Service Portal. Please note that changing this field may cause existing bookmarks to break. All networks that are part of this combined network will have their enrollment string appended by '-network_type'. If left empty, all exisitng enrollment strings will be deleted.</value>
	[DataMember(Name = "enrollmentString")]
	public string EnrollmentString { get; set; } = string.Empty;
}
