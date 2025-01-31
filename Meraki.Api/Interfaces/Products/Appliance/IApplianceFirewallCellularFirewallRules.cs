﻿namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceFirewallCellularFirewallRules
{
	/// <summary>
	/// Return the cellular firewall rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/appliance/firewall/cellularFirewallRules")]
	Task<CellularFirewallRules> GetNetworkApplianceFirewallCellularFirewallRulesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the cellular firewall rules of an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="mxCellularFirewallRules">Body for updating network cellular firewall rules</param>
	[Put("/networks/{networkId}/appliance/firewall/cellularFirewallRules")]
	Task<CellularFirewallRules> UpdateNetworkApplianceFirewallCellularFirewallRulesAsync(
		[AliasAs("networkId")] string networkId,
		[Body] CellularFirewallRules mxCellularFirewallRules,
		CancellationToken cancellationToken = default
		);
}
