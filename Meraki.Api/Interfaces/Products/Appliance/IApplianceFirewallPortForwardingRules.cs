﻿namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceFirewallPortForwardingRules
{
	/// <summary>
	/// Return the port forwarding rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkApplianceFirewallPortForwardingRules")]
	[Get("/networks/{networkId}/appliance/firewall/portForwardingRules")]
	Task<PortForwardingRules> GetNetworkApplianceFirewallPortForwardingRulesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the port forwarding rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkPortForwardingRules">Body for updating port forwarding rules</param>
	[ApiOperationId("updateNetworkApplianceFirewallPortForwardingRules")]
	[Put("/networks/{networkId}/appliance/firewall/portForwardingRules")]
	Task<PortForwardingRules> UpdateNetworkApplianceFirewallPortForwardingRulesAsync(
		[AliasAs("networkId")] string networkId,
		[Body] PortForwardingRules updateNetworkPortForwardingRules,
		CancellationToken cancellationToken = default
		);
}
