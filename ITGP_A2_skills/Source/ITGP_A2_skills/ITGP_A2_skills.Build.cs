// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ITGP_A2_skills : ModuleRules
{
	public ITGP_A2_skills(ReadOnlyTargetRules Target) : base(Target)
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
			"ITGP_A2_skills",
			"ITGP_A2_skills/Variant_Platforming",
			"ITGP_A2_skills/Variant_Platforming/Animation",
			"ITGP_A2_skills/Variant_Combat",
			"ITGP_A2_skills/Variant_Combat/AI",
			"ITGP_A2_skills/Variant_Combat/Animation",
			"ITGP_A2_skills/Variant_Combat/Gameplay",
			"ITGP_A2_skills/Variant_Combat/Interfaces",
			"ITGP_A2_skills/Variant_Combat/UI",
			"ITGP_A2_skills/Variant_SideScrolling",
			"ITGP_A2_skills/Variant_SideScrolling/AI",
			"ITGP_A2_skills/Variant_SideScrolling/Gameplay",
			"ITGP_A2_skills/Variant_SideScrolling/Interfaces",
			"ITGP_A2_skills/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
