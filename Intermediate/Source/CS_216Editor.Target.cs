using UnrealBuildTool;

public class CS_216EditorTarget : TargetRules
{
	public CS_216EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("CS_216");
	}
}
