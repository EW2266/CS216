using UnrealBuildTool;

public class CS_216ClientTarget : TargetRules
{
	public CS_216ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("CS_216");
	}
}
