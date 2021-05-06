﻿using Relativity.Testing.Framework.Api.Services;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Api.Strategies
{
	internal class ProductionsPlaceholderCreateStrategy : CreateWorkspaceEntityStrategy<ProductionPlaceholder>
	{
		private readonly IRestService _restService;
		private readonly IGetWorkspaceEntityByIdStrategy<ProductionPlaceholder> _getWorkspaceEntityByIdStrategy;

		public ProductionsPlaceholderCreateStrategy(
			IRestService restService,
			IGetWorkspaceEntityByIdStrategy<ProductionPlaceholder> getWorkspaceEntityByIdStrategy)
		{
			_restService = restService;
			_getWorkspaceEntityByIdStrategy = getWorkspaceEntityByIdStrategy;
		}

		protected override ProductionPlaceholder DoCreate(int workspaceId, ProductionPlaceholder entity)
		{
			entity.FillRequiredProperties();

			var dto = new
			{
				workspaceArtifactID = workspaceId,
				placeholder = entity
			};

			entity.ArtifactID = _restService.Post<int>("Relativity.Productions.Services.IProductionModule/Production%20Placeholder%20Manager/CreateSingleAsync", dto);

			return _getWorkspaceEntityByIdStrategy.Get(workspaceId, entity.ArtifactID);
		}
	}
}
