// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GravityJumping : ModuleRules
{
	public GravityJumping(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
