namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISms
	{
		/// <summary>
		/// List the devices enrolled in an SM network with various specified fields and filters
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="fields">Additional fields that will be displayed for each device. Multiple fields can be passed in as comma separated values.     The default fields are: id, name, tags, ssid, wifiMac, osName, systemModel, uuid, and serialNumber. The additional fields are: ip,     systemType, availableDeviceCapacity, kioskAppName, biosVersion, lastConnected, missingAppsCount, userSuppliedAddress, location, lastUser,     ownerEmail, ownerUsername, publicIp, phoneNumber, diskInfoJson, deviceCapacity, isManaged, hadMdm, isSupervised, meid, imei, iccid,     simCarrierNetwork, cellularDataUsed, isHotspotEnabled, createdAt, batteryEstCharge, quarantined, avName, avRunning, asName, fwName,     isRooted, loginRequired, screenLockEnabled, screenLockDelay, autoLoginDisabled, autoTags, hasMdm, hasDesktopAgent, diskEncryptionEnabled,     hardwareEncryptionCaps, passCodeLock, usesHardwareKeystore, and androidSecurityPatchVersion. (optional)</param>
		/// <param name="wifiMacs">Filter devices by wifi mac(s). Multiple wifi macs can be passed in as comma separated values. (optional)</param>
		/// <param name="serials">Filter devices by serial(s). Multiple serials can be passed in as comma separated values. (optional)</param>
		/// <param name="ids">Filter devices by id(s). Multiple ids can be passed in as comma separated values. (optional)</param>
		/// <param name="scope">Specify a scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags as comma separated values. (optional)</param>
		/// <param name="batchSize">Number of devices to return, 1000 is the default as well as the max. (optional)</param>
		/// <param name="batchToken">If the network has more devices than the batch size, a batch token will be returned     as a part of the device list. To see the remainder of the devices, pass in the batchToken as a parameter in the next request.     Requests made with the batchToken do not require additional parameters as the batchToken includes the parameters passed in     with the original request. Additional parameters passed in with the batchToken will be ignored. (optional)</param>
		[Get("/networks/{networkId}/sm/devices")]
		Task<SmDevices> GetNetworkSmDevicesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("fields")] string fields = null!,
			[AliasAs("wifiMacs")] string wifiMacs = null!,
			[AliasAs("serials")] string serials = null!,
			[AliasAs("ids")] string ids = null!,
			[AliasAs("scope")] string scope = null!,
			[AliasAs("batchSize")] int? batchSize = null,
			[AliasAs("batchToken")] string batchToken = null!,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the network adapters of a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="deviceId">The device id</param>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/networkAdapters")]
		Task<List<NetworkAdapter>> GetNetworkSmNetworkAdaptersAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("deviceId")] string deviceId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return historical records of various Systems Manager client metrics for desktop devices.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="id">The SM id</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		[Get("/networks/{networkId}/sm/{id}/performanceHistory")]
		Task<List<SmDevicePerformanceHistory>> GetNetworkSmPerformanceHistoryAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("id")] string id,
			[AliasAs("perPage")] int? perPage = 1000,
			[AliasAs("startingAfter")] string startingAfter = null!,
			[AliasAs("endingBefore")] string endingBefore = null!,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List all profiles in a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/sm/profiles")]
		Task<SmProfile> GetNetworkSmProfilesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the restrictions on a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="deviceId">The device id</param>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/restrictions")]
		Task<List<SmDeviceRestrictions>> GetNetworkSmRestrictionsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("deviceId")] string deviceId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the security centers on a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="deviceId">The device id</param>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/securityCenters")]
		Task<List<SecurityCenter>> GetNetworkSmSecurityCentersAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("deviceId")] string deviceId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Get a list of softwares associated with a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="deviceId">The device id</param>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/softwares")]
		Task<List<Software>> GetNetworkSmSoftwaresAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("deviceId")] string deviceId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Get the profiles associated with a user
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="userId">The user id</param>
		[Get("/networks/{networkId}/sm/users/{userId}/deviceProfiles")]
		Task<List<DeviceProfile>> GetNetworkSmUserDeviceProfilesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("userId")] string userId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Get a list of softwares associated with a user
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="userId">The user id</param>
		[Get("/networks/{networkId}/sm/users/{userId}/softwares")]
		Task<List<Software>> GetNetworkSmUserSoftwaresAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("userId")] string userId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the owners in an SM network with various specified fields and filters
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="ids">Filter users by id(s). Multiple ids can be passed in as comma separated values. (optional)</param>
		/// <param name="usernames">Filter users by username(s). Multiple usernames can be passed in as comma separated values. (optional)</param>
		/// <param name="emails">Filter users by email(s). Multiple emails can be passed in as comma separated values. (optional)</param>
		/// <param name="scope">Specifiy a scope (one of all, none, withAny, withAll, withoutAny, withoutAll) and a set of tags as comma separated values. (optional)</param>
		[Get("/networks/{networkId}/sm/users")]
		Task<List<SmNetworkUsers>> GetNetworkSmUsersAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("ids")] string ids = null!,
			[AliasAs("usernames")] string usernames = null!,
			[AliasAs("emails")] string emails = null!,
			[AliasAs("scope")] string scope = null!,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the saved SSID names on a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="deviceId">The device id</param>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/wlanLists")]
		Task<List<WlanList>> GetNetworkSmWlanListsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("deviceId")] string deviceId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Move a set of devices to a new network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="moveNetworkSmDevices">Body for moving devices</param>
		[Post("/networks/{networkId}/sm/devices/move")]
		Task<MoveNetworkSmDevices> MoveNetworkSmDevicesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] MoveNetworkSmDevices moveNetworkSmDevices,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Refresh the details of a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="deviceId">The device id</param>
		[Post("/networks/{networkId}/sm/devices/{deviceId}/refreshDetails")]
		Task RefreshNetworkSmDeviceDetailsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("deviceId")] string deviceId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Unenroll a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="deviceId">The device id</param>
		[Post("/networks/{networkId}/sm/devices/{deviceId}/unenroll")]
		Task<UpdateOnboardingStatusResponse> UnenrollNetworkSmDeviceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("deviceId")] string deviceId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Modify the fields of a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkSmDeviceFields">Body for modifying a device</param>
		[Put("/networks/{networkId}/sm/devices/fields")]
		Task<SmDeviceFieldsUpdateRequest> UpdateNetworkSmDeviceFieldsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SmDeviceFieldsUpdateRequest updateNetworkSmDeviceFields,
			CancellationToken cancellationToken = default
			);
	}
}
