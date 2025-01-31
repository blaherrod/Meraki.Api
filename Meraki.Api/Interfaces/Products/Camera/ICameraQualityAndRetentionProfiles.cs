namespace Meraki.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICameraQualityAndRetentionProfiles
{
	/// <summary>
	/// List the quality retention profiles for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkCameraQualityRetentionProfiles")]
	[Get("/networks/{networkId}/camera/qualityRetentionProfiles")]
	Task<List<CameraQualityRetentionProfile>> GetNetworkCameraQualityRetentionProfilesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Retrieve a single quality retention profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="qualityRetentionProfileId">The quality retention profile id</param>
	[ApiOperationId("getNetworkCameraQualityRetentionProfile")]
	[Get("/networks/{networkId}/camera/qualityRetentionProfiles/{qualityRetentionProfileId}")]
	Task<CameraQualityRetentionProfile> GetNetworkCameraQualityRetentionProfileAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("qualityRetentionProfileId")] string qualityRetentionProfileId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Creates new quality retention profile for this network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkCameraQualityRetentionProfile">Body for creating quality retention profile</param>
	[ApiOperationId("createNetworkCameraQualityRetentionProfile")]
	[Post("/networks/{networkId}/camera/qualityRetentionProfiles")]
	Task<CameraQualityRetentionProfile> CreateNetworkCameraQualityRetentionProfileAsync(
		[AliasAs("networkId")] string networkId,
		[Body] CameraQualityRetentionProfileCreateUpdateRequest createNetworkCameraQualityRetentionProfile,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update an existing quality retention profile for this network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="qualityRetentionProfileId">The quality retention profile id</param>
	/// <param name="updateNetworkCameraQualityRetentionProfile">Body for updating quality retention profile</param>
	[ApiOperationId("updateNetworkCameraQualityRetentionProfile")]
	[Put("/networks/{networkId}/camera/qualityRetentionProfiles/{qualityRetentionProfileId}")]
	Task<CameraQualityRetentionProfile> UpdateNetworkCameraQualityRetentionProfileAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("qualityRetentionProfileId")] string qualityRetentionProfileId,
		[Body] CameraQualityRetentionProfileCreateUpdateRequest updateNetworkCameraQualityRetentionProfile,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete an existing quality retention profile for this network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="qualityRetentionProfileId">The quality retention profile id</param>
	[ApiOperationId("deleteNetworkCameraQualityRetentionProfile")]
	[Delete("/networks/{networkId}/camera/qualityRetentionProfiles/{qualityRetentionProfileId}")]
	Task DeleteNetworkCameraQualityRetentionProfileAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("qualityRetentionProfileId")] string qualityRetentionProfileId,
		CancellationToken cancellationToken = default);
}
