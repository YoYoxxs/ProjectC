using UnrealBuildTool;

public class Prime_cuxServerTarget : TargetRules
{
	public Prime_cuxServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Prime_cux");
	}
}
