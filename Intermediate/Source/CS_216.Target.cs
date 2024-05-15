using UnrealBuildTool;

public class CS_216Target : TargetRules
{
	public CS_216Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("CS_216");
	}
}
