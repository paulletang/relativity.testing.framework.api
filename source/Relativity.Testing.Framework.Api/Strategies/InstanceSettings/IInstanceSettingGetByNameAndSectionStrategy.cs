﻿using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Api.Strategies
{
	/// <summary>
	/// Represents the strategy of getting the instance setting by name and section.
	/// </summary>
	internal interface IInstanceSettingGetByNameAndSectionStrategy
	{
		/// <summary>
		/// Gets the entity by the specified name and section.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <param name="section">The section.</param>
		/// <returns>The <see cref="InstanceSetting"/> object or <see langword="null"/>.</returns>
		InstanceSetting Get(string name, string section);
	}
}
