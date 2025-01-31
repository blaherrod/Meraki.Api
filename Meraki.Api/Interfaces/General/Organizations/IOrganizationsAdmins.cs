﻿namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Admins interface
/// </summary>
public interface IOrganizationsAdmins
{
	/// <summary>
	///	List the dashboard administrators in this organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/admins")]
	Task<List<Admin>> GetOrganizationAdminsAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a new dashboard administrator
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createOrganizationAdmin">Body for creating organization admin</param>
	[Post("/organizations/{organizationId}/admins")]
	Task<Admin> CreateOrganizationAdminAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] AdminCreationRequest createOrganizationAdmin,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Revoke all access for a dashboard administrator within this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">The admin id</param>
	[Delete("/organizations/{organizationId}/admins/{id}")]
	Task DeleteOrganizationAdminAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("id")] string id,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update an administrator
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">The admin id</param>
	/// <param name="adminUpdateRequest">Body for updating admin</param>
	[Put("/organizations/{organizationId}/admins/{id}")]
	Task<Admin> UpdateOrganizationAdminAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("id")] string id,
		[Body] AdminUpdateRequest adminUpdateRequest,
		CancellationToken cancellationToken = default);
}
