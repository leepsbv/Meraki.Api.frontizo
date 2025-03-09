﻿namespace Meraki.Api.Data;

public abstract class ItemsResponseWithMeta<T>
{
	/// <summary>
	///	Meta details about the result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public ItemsResponseMeta Meta { get; set; } = new();

	/// <summary>
	/// List of Items&lt;T&gt;.
	/// </summary>
	// [ApiAccess(ApiAccess.Read)] - Defined on the concrete class
	[DataMember(Name = "items")]
	public abstract List<T> Items { get; set; }
}
