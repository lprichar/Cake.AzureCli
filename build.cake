///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var version = Argument("pubver", "");

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("Publish")
   .Does(() =>
{
   if (string.IsNullOrEmpty(version)) throw new ArgumentNullException(nameof(version));
   Information("Publishing Cake.AzureCli.csproj as version " + version);
   DotNetCorePack("./src/Cake.AzureCli/Cake.AzureCli.csproj", new DotNetCorePackSettings {
      NoBuild = false,
      IncludeSymbols = true,
      Configuration = configuration,
      MSBuildSettings = new DotNetCoreMSBuildSettings().SetVersion(version)
   });
});

Task("Default")
.Does(() => {
   Information("Try: .\\build.ps1 -target=Publish --pubver=\"1.0.0.0\"");
});

RunTarget(target);