﻿namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceSecurityIntrusion
{
	/// <summary>
	/// Returns all supported intrusion settings for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/appliance/security/intrusion")]
	Task<OrganizationSecurityIntrusion> GetOrganizationApplianceSecurityIntrusionAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Sets supported intrusion settings for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="securityIntrusion">Body for updating security intrusion settings</param>
	[Put("/organizations/{organizationId}/appliance/security/intrusion")]
	Task<OrganizationSecurityIntrusion> UpdateOrganizationApplianceSecurityIntrusionAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] OrganizationSecurityIntrusion securityIntrusion,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Returns all supported intrusion settings for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkApplianceSecurityIntrusion")]
	[Get("/networks/{networkId}/appliance/security/intrusion")]
	Task<NetworkSecurityIntrusion> GetNetworkApplianceSecurityIntrusionAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Set the supported intrusion settings for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="networkSecurityIntrusion">Body for updating security intrusion settings</param>
	[ApiOperationId("updateNetworkApplianceSecurityIntrusion")]
	[Put("/networks/{networkId}/appliance/security/intrusion")]
	Task<NetworkSecurityIntrusion> UpdateNetworkApplianceSecurityIntrusionAsync(
		[AliasAs("networkId")] string networkId,
		[Body] NetworkSecurityIntrusion networkSecurityIntrusion,
		CancellationToken cancellationToken = default
		);
}
