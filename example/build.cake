#reference "../src/Cake.AzureCli/bin/Debug/netstandard2.0/Cake.AzureCli.dll"

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
   dynamic result = AzLogin(new AzLoginSettings {
      Username = username,
      Arguments = new ProcessArgumentBuilder()
         .Append("--password").AppendSecret(password)
   });

   // If azure commands result in json (typically) they are converted to dynamic objects
   Information("1st tenant = " + result[0].tenantId);

   // 'az account set' is accessed with AzAccountSet
   AzAccountSet(new AzAccountSetSettings {
      Subscription = subscription
   });
});

Task("Default")
.Does(() => {
   Information("try: build.ps1 -target \"Login\" --username=\"user@address.com\" -password=myPassword -subscription=5d544c5d-b9b6-44b5-9361-e3f72839badf");
});

RunTarget(target);