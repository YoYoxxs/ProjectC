using UnrealBuildTool;

public class Prime_cuxEditorTarget : TargetRules
{
	public Prime_cuxEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Prime_cux");
	}
}
