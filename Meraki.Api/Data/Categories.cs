﻿using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Categories
	/// </summary>
	[DataContract]
	public class Categories
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;
	}
}
