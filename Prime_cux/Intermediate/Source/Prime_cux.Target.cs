using UnrealBuildTool;

public class Prime_cuxTarget : TargetRules
{
	public Prime_cuxTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Prime_cux");
	}
}
