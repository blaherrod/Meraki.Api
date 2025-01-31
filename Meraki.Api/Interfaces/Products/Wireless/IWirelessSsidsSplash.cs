﻿namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsSplash
{
	/// <summary>
	/// Modify the splash page settings for the given SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="updateNetworkWirelessSsidSplashSettings"></param>
	[Put("/networks/{networkId}/wireless/ssids/{number}/splash/settings")]
	Task<SsidSplashSettings> UpdateNetworkWirelessSsidSplashSettingsAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("number")] string number,
		[Body] SsidSplashSettings updateNetworkWirelessSsidSplashSettings,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Display the splash page settings for the given SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/splash/settings")]
	Task<SsidSplashSettings> GetNetworkWirelessSsidSplashSettingsAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("number")] string number,
		CancellationToken cancellationToken = default
		);
}
