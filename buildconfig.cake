public class BuildConfig
{
    private const string Version = "3.1.0";
    private const bool IsPreRelease = false;

    public readonly string SrcDir = "./src/";
    public readonly string OutDir = "./build/";    
    
    public string Target { get; private set; }
    public string SemVer { get; private set; }
    public string BuildVersion { get; private set; }
    public string BuildProfile { get; private set; }
    public bool IsTeamCityBuild { get; private set; }
    
    public static BuildConfig Create(
        ICakeContext context,
        BuildSystem buildSystem)
    {
        if (context == null)
            throw new ArgumentNullException("context");

        var buildRevision = context.Argument("buildrevision", "0");

        return new BuildConfig
        {
            Target = context.Argument("target", "Default"),
            SemVer = Version + (IsPreRelease ? "-b" + buildRevision : string.Empty),
            BuildVersion = Version + "." + buildRevision,
            BuildProfile = context.Argument("configuration", "Release"),
            IsTeamCityBuild = buildSystem.TeamCity.IsRunningOnTeamCity
        };
    }
}
