﻿using System.Collections.Generic;
using Relativity.Testing.Framework.Api.Strategies;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Api.Services
{
	/// <summary>
	/// Represents the tab API service for interacting with Tabs.
	/// </summary>
	/// <example>
	/// <code>
	/// ITabService _tabService = relativityFacade.Resolve&lt;ITabService&gt;();
	/// </code>
	/// </example>
	public interface ITabService
	{
		/// <summary>
		/// Creates the specified tab.
		/// </summary>
		/// <param name="workspaceId">The Artifact ID of the workspace where you want to add the new tab,
		/// or use -1 to indicate the admin-level context.</param>
		/// <param name="entity">The [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html) to create.</param>
		/// <returns>The created [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html).</returns>
		/// <example>
		/// <code>
		/// int workspaceArtifactID = -1;
		/// Tab tab = _tabService.Create(workspaceArtifactID, new Tab());
		/// </code>
		/// </example>
		/// <example>
		/// <code>
		/// int workspaceArtifactID = 1234567;
		/// Tab tab = new Tab
		/// {
		///     Name = "MySpecialTab",
		///     LinkType = TabLinkType.Parent
		/// };
		/// Tab tab = _tabService.Create(workspaceArtifactID, tab);
		/// </code>
		/// </example>
		Tab Create(int workspaceId, Tab entity);

		/// <summary>
		/// Requires the specified tab.
		/// <list type="number">
		/// <item><description>If [ArtifactID](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Artifact.html#Relativity_Testing_Framework_Models_Artifact_ArtifactID) property of <paramref name="entity"/> has positive value, gets entity by ID and updates it.</description></item>
		/// <item><description>If [Name](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.NamedArtifact.html#Relativity_Testing_Framework_Models_NamedArtifact_Name) property of <paramref name="entity"/> have a value, gets entity by name and updates it if it exists.</description></item>
		/// <item><description>Otherwise creates a new [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html).</description></item>
		/// </list>
		/// </summary>
		/// <param name="workspaceId">The Artifact ID of the workspace where you want to require tab,
		/// or use -1 to indicate the admin-level context.</param>
		/// <param name="entity">The [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html) to require.</param>
		/// <returns>The [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html) required.</returns>
		/// <example>
		/// In this example, the tab does not exist, so it will be created.
		/// <code>
		/// int workspaceArtifactID = 1234567;
		/// Tab tab = new Tab
		/// {
		///     Name = "MySpecialTab",
		///     LinkType = TabLinkType.Parent
		/// };
		/// Tab tab = _tabService.Require(workspaceArtifactID, tab);
		/// </code>
		/// However, if the tab did exist, it would be updated to match the definition.
		/// </example>
		Tab Require(int workspaceId, Tab entity);

		/// <summary>
		/// Deletes the [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html) by ID.
		/// </summary>
		/// <param name="workspaceId">The Artifact ID of the workspace where you want to delete the tab,
		/// or use -1 to indicate the admin-level context.</param>
		/// <param name="entityId">The artifact ID of the [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html).</param>
		/// <example>
		/// <code>
		/// int workspaceArtifactID = 1234567;
		/// _tabService.Delete(workspaceArtifactID, tab.ArtifactId);
		/// </code>
		/// </example>
		void Delete(int workspaceId, int entityId);

		/// <summary>
		/// Gets the [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html) by the specified ID.
		/// </summary>
		/// <param name="workspaceId">The Artifact ID of the workspace where you want to get the tab,
		/// or use -1 to indicate the admin-level context.</param>
		/// <param name="entityId">The artifact ID of the [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html).</param>
		/// <returns>>The [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html) entity.</returns>
		/// <example>
		/// <code>
		/// int workspaceArtifactID = 1234567;
		/// Tab tab = _tabService.Get(workspaceArtifactID, tab.ArtifactId);
		/// </code>
		/// </example>
		Tab Get(int workspaceId, int entityId);

		/// <summary>
		/// Gets the [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html) by the specified name.
		/// </summary>
		/// <param name="workspaceId">The Artifact ID of the workspace where you want to get the tab,
		/// or use -1 to indicate the admin-level context.</param>
		/// <param name="entityName">The name of the tab.</param>
		/// <returns>>The [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html) entity.</returns>
		/// <example>
		/// <code>
		/// int workspaceArtifactID = 1234567;
		/// Tab tab = _tabService.Get(workspaceArtifactID, "MyTabName");
		/// </code>
		/// </example>
		Tab Get(int workspaceId, string entityName);

		/// <summary>
		/// Updates the specified [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html).
		/// </summary>
		/// <param name="workspaceId">The Artifact ID of the workspace where you want to update the tab,
		/// or use -1 to indicate the admin-level context.</param>
		/// <param name="entity">The [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html) to update.
		/// Must include the ArtifactID of the Tab in the model.</param>
		/// <example>
		/// <code>
		/// int workspaceArtifactID = 1234567;
		/// Tab tab = _tabService.Get(workspaceArtifactID, "MyTabName");
		///
		/// tab.Name = "AnotherName"
		///
		/// _tabService.Update(workspaceArtifactID, tab);
		/// </code>
		/// </example>
		void Update(int workspaceId, Tab entity);

		/// <summary>
		/// Retrieves a list of all object types in a workspace available for creating or updating a tab.
		/// </summary>
		/// <param name="workspaceId">The Artifact ID of the workspace that you want to retrieve available object types for.</param>
		/// <returns>>List of [ObjectType](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.ObjectType.html).</returns>
		/// <example>
		/// <code>
		/// int workspaceArtifactID = 1234567;
		/// List&lt;ObjectType&gt; result = _tabService.GetAvailableObjectTypes(workspaceArtifactID);
		/// </code>
		/// </example>
		List<ObjectType> GetAvailableObjectTypes(int workspaceId);

		/// <summary>
		/// Gets the [Meta](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Meta.html) with admin-level metadata about admin and system tabs.
		/// </summary>
		/// <example>
		/// <code>
		/// Meta meta = _tabService.GetAdminLevelMetadata();
		/// </code>
		/// </example>
		/// <returns>The [Meta](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Meta.html) entity.</returns>
		Meta GetAdminLevelMetadata();

		/// <summary>
		/// Retrieves a list of parent tabs, which can be associated with a tab for adding or updating it.
		/// </summary>
		/// /// <param name="workspaceId">The Artifact ID of the workspace that you want to retrieve parent tabs for.</param>
		/// <example>
		/// <code>
		/// int workspaceArtifactID = 1234567;
		/// List&lt;TabEligibleParentV1&gt; result = _tabService.GetEligibleParents(workspaceArtifactID);
		/// </code>
		/// </example>
		/// <returns>List of <see cref="TabEligibleParent"/> entities.</returns>
		List<TabEligibleParent> GetEligibleParents(int workspaceId);

		/// <summary>
		/// Gets current order of the tabs in a workspace.
		/// </summary>
		/// <param name="workspaceId">The Artifact ID of the workspace that you want to retrieve tabs order for.</param>
		/// <returns>Ordered list of [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html)s. Only basic information and Order fields are filled.</returns>
		/// <example>
		/// <code>
		/// int workspaceArtifactID = 1234567;
		/// List&lt;Tab&gt; = _tabService.GetTabsOrder(workspaceArtifactID);
		/// </code>
		/// </example>
		List<Tab> GetTabsOrder(int workspaceId);

		/// <summary>
		/// Retrieves a list of tabs with information about each tab that the calling user can navigate to in a specific workspace.
		/// </summary>
		/// <param name="workspaceId">The Artifact ID of the workspace that you want to retrieve tabs navigation information for.</param>
		/// <returns>List of [Tab](https://relativitydev.github.io/relativity.testing.framework/api/Relativity.Testing.Framework.Models.Tab.html) entities.</returns>
		/// <example>
		/// <code>
		/// int workspaceArtifactID = 1234567;
		/// List&lt;Tab&gt; result = _tabService.GetAllForNavigation(workspaceArtifactID);
		/// </code>
		/// </example>
		List<Tab> GetAllForNavigation(int workspaceId);
	}
}
