// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ArcaneJungle : ModuleRules
{
	public ArcaneJungle(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
