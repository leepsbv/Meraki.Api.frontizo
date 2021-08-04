﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Application usage
	/// </summary>
	[DataContract]
	public partial class SubclassApplicationUsage
	{
		/// <summary>
		/// Application
		/// </summary>
		[DataMember(Name = "application")]
		public string Application { get; set; } = string.Empty;

		/// <summary>
		/// Recv
		/// </summary>
		[DataMember(Name = "recv")]
		public int Recv { get; set; }

		/// <summary>
		/// Sent
		/// </summary>
		[DataMember(Name = "sent")]
		public int Sent { get; set; }
	}
}
