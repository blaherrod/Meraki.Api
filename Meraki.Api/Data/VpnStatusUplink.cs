﻿using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Uplink
	/// </summary>
	[DataContract]
	public partial class VpnStatusUplink
	{
		/// <summary>
		/// Interface
		/// </summary>
		[DataMember(Name = "interface")]
		public string Interface { get; set; } = string.Empty;

		/// <summary>
		/// Public ip
		/// </summary>
		[DataMember(Name = "publicIp")]
		public string PublicIp { get; set; } = string.Empty;
	}
}
