using UnrealBuildTool;

public class CS_216ServerTarget : TargetRules
{
	public CS_216ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("CS_216");
	}
}
