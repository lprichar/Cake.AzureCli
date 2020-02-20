#reference "../src/Cake.AzureCli/bin/Debug/netstandard2.0/Cake.AzureCli.dll"
//#addin "nuget:?package=Cake.AzureCli&version=1.0.0"

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
   // "'az login' is accessed via AzLogin. Arguments can be customized if necessary with as ProcessArgumentBuilder
   dynamic loginResult = Az().Login(new AzLoginSettings {
      Username = username,
      Arguments = new ProcessArgumentBuilder()
         .Append("--password").AppendSecret(password)
   });

   if (subscription == null) {
      // If azure commands result in json (typically) they are converted to dynamic objects
      var firstSubscription = loginResult[0].id;
      Information($"Subscription is null, using 1st subscription ({firstSubscription})");
      subscription = firstSubscription;
   }

   // 'az account set' is accessed with AzAccountSet
   Az().Account.Set(new AzAccountSetSettings {
      Subscription = subscription
   });

   // listing names of all resource groups
   dynamic allResourceGroups = Az().Group.List(new AzGroupListSettings());
   foreach (var resourceGroup in allResourceGroups) {
      Information(resourceGroup.name);
   }
});

Task("Default")
.Does(() => {
   Information("try: .\\build.ps1 -target=\"Login\" --username=\"user@address.com\" -password=myPassword -subscription=subscriptionid");
});

RunTarget(target);