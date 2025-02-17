﻿using System.Linq;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Api.Strategies
{
	internal static class FolderDtoMappingExtensions
	{
		internal static Folder DoMappingToFolder(this FolderDto dto)
		{
			return new Folder
			{
				ArtifactID = dto.ArtifactID,
				Name = dto.Name,
				ParentFolder = dto.ParentFolder,
				AccessControlListIsInherited = dto.AccessControlListIsInherited,
				HasChildren = dto.HasChildren,
				Selected = dto.Selected,
				Permissions = dto.Permissions?.DoMappingToFolderPermission(),
				Children = dto.Children?.Select(childDto => childDto.DoMappingToFolder()).ToList(),
				SystemCreatedOn = dto.SystemCreatedOn,
				SystemLastModifiedOn = dto.SystemLastModifiedOn
			};
		}

		internal static FolderPermission DoMappingToFolderPermission(this FolderPermissionDto dto)
		{
			return new FolderPermission
			{
				Add = dto.Add,
				Delete = dto.Delete,
				Edit = dto.Edit,
				Secure = dto.Secure
			};
		}

		internal static FolderAccessStatus DoMappingToFolderAccessStatus(this FolderAccessStatusDto dto)
		{
			return new FolderAccessStatus
			{
				CanView = dto.CanView,
				Exists = dto.Exists
			};
		}

		internal static FolderMoveResponse DoMappingToFolderMoveResponse(this FolderMoveResponseDto dto)
		{
			return new FolderMoveResponse
			{
				ProcessState = dto.ProcessState,
				TotalOperations = dto.TotalOperations,
				OperationsCompleted = dto.OperationsCompleted
			};
		}
	}
}
