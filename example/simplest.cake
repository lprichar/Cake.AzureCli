#reference "../src/Cake.AzureCli/bin/Debug/net7.0/Cake.AzureCli.dll"

var target = Argument("target", "Default");
var username = Argument<string>("username", null);
var password = Argument<string>("password", null);

Task("Login")
   .Does(() =>
{
   // 'az login' is accessed via Az().Login()
   Az().Login(new AzLoginSettings {
      Username = username,
      // all commands can be customized if necessary with a ProcessArgumentBuilder
      Arguments = new ProcessArgumentBuilder()
         // anything appended with .AppendSecret() will be rendered as [REDACTED] 
         //    if cake is run with `-verbosity=diagnostic`
         .Append("--password").AppendSecret(password)
   });
});

Task("ListResourceGroups")
   .IsDependentOn("Login") // yayy dependency management!
   .Does(() =>
{
   // listing names of all resource groups
   Information("Resource Groups:");
   // all results are strongly typed as dynamic if results are json
   dynamic allResourceGroups = Az().Group.List(new AzGroupListSettings());
   foreach (var resourceGroup in allResourceGroups) {
      Information(resourceGroup.name);
   }
});

RunTarget(target);