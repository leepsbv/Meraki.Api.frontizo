﻿namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsLoginSecurity
{
	/// <summary>
	/// Returns the login security settings for an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/loginSecurity")]
	Task<LoginSecurity> GetOrganizationLoginSecurityAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the login security settings for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="updateOrganizationLoginSecurity">Body for updating login settings</param>
	[Put("/organizations/{organizationId}/loginSecurity")]
	Task<LoginSecurity> UpdateOrganizationLoginSecurityAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] LoginSecurity updateOrganizationLoginSecurity,
		CancellationToken cancellationToken = default);
}
