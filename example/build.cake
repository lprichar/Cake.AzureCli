#reference "../src/Cake.AzureCli/bin/Debug/net7.0/Cake.AzureCli.dll"

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var username = Argument<string>("username", null);
var password = Argument<string>("password", null);
var subscription = Argument<string>("subscription", null);

Task("Login")
   .Does(() =>
{
   // "'az login' is accessed via Az().Login()
   dynamic loginResult = Az().Login(new AzLoginSettings {
      Username = username,
      // all commands can be customized if necessary with a ProcessArgumentBuilder
      Arguments = new ProcessArgumentBuilder()
         // anything appended with .AppendSecret() will be rendered as [REDACTED] if cake is run with `-verbosity=diagnostic`
         .Append("--password").AppendSecret(password)
   });

   if (subscription == null) {
      // If azure commands result in json they are converted to dynamic objects
      var firstSubscription = loginResult[0].id;
      Information($"Subscription is null, using 1st subscription ({firstSubscription})");
      subscription = firstSubscription;
   }

   // 'az account set' is accessed with Az().Account.Set()
   Az().Account.Set(new AzAccountSetSettings {
      Name = subscription
   });
});

Task("ListResourceGroups")
   .IsDependentOn("Login") // yayy dependency management!
   .Does(() =>
{
   // listing names of all resource groups
   Information("Resource Groups:");
   dynamic allResourceGroups = Az().Group.List(new AzGroupListSettings());
   foreach (var resourceGroup in allResourceGroups) {
      Information(resourceGroup.name);
   }
});

Task("Default")
.Does(() => {
   Information("try: .\\build.ps1 --target=\"ListResourceGroups\" --username=\"user@address.com\" --password=myPassword");
});

RunTarget(target);