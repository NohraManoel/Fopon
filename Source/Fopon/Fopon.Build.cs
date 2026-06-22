// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Fopon : ModuleRules
{
	public Fopon(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Fopon",
			"Fopon/Variant_Platforming",
			"Fopon/Variant_Platforming/Animation",
			"Fopon/Variant_Combat",
			"Fopon/Variant_Combat/AI",
			"Fopon/Variant_Combat/Animation",
			"Fopon/Variant_Combat/Gameplay",
			"Fopon/Variant_Combat/Interfaces",
			"Fopon/Variant_Combat/UI",
			"Fopon/Variant_SideScrolling",
			"Fopon/Variant_SideScrolling/AI",
			"Fopon/Variant_SideScrolling/Gameplay",
			"Fopon/Variant_SideScrolling/Interfaces",
			"Fopon/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
