namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkFloorPlan
/// </summary>
[DataContract]
public class FloorPlanUpdateRequest
{
	/// <summary>
	/// The name of your floor plan.
	/// </summary>
	/// <value>The name of your floor plan.</value>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Gets or Sets Center
	/// </summary>
	[DataMember(Name = "center")]
	public GeoLocation? Center { get; set; }

	/// <summary>
	/// Gets or Sets BottomLeftCorner
	/// </summary>
	[DataMember(Name = "bottomLeftCorner")]
	public GeoLocation? BottomLeftCorner { get; set; }

	/// <summary>
	/// Gets or Sets BottomRightCorner
	/// </summary>
	[DataMember(Name = "bottomRightCorner")]
	public GeoLocation? BottomRightCorner { get; set; }

	/// <summary>
	/// Gets or Sets TopLeftCorner
	/// </summary>
	[DataMember(Name = "topLeftCorner")]
	public GeoLocation? TopLeftCorner { get; set; }

	/// <summary>
	/// Gets or Sets TopRightCorner
	/// </summary>
	[DataMember(Name = "topRightCorner")]
	public GeoLocation? TopRightCorner { get; set; }

	/// <summary>
	/// The file contents (a base 64 encoded string) of your new image. Supported formats are PNG, GIF, and JPG. Note that all images are saved as PNG files, regardless of the format they are uploaded in. If you upload a new image, and you do NOT specify any new geolocation fields (&#39;center, &#39;topLeftCorner&#39;, etc), the floor plan will be recentered with no rotation in order to maintain the aspect ratio of your new image.
	/// </summary>
	/// <value>The file contents (a base 64 encoded string) of your new image. Supported formats are PNG, GIF, and JPG. Note that all images are saved as PNG files, regardless of the format they are uploaded in. If you upload a new image, and you do NOT specify any new geolocation fields (&#39;center, &#39;topLeftCorner&#39;, etc), the floor plan will be recentered with no rotation in order to maintain the aspect ratio of your new image.</value>
	[DataMember(Name = "imageContents")]
	public string? ImageContents { get; set; }
}
