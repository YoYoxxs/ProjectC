using UnrealBuildTool;

public class Prime_cuxClientTarget : TargetRules
{
	public Prime_cuxClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Prime_cux");
	}
}
