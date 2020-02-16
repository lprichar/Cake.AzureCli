#reference "../src/Cake.AzureCli/bin/Debug/netstandard2.0/Cake.AzureCli.dll"

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var username = Argument<string>("username");
var password = Argument<string>("password");
var subscription = Argument<string>("subscription");

Task("Login")
   .Does(() =>
{
   var result = AzLogin(new AzLoginSettings {
      Username = username,
      Arguments = new ProcessArgumentBuilder()
         .Append("--password").AppendSecret(password)
   });
   Information("1st tenant = " + result[0].tenantId);
   AzAccountSet(new AzAccountSetSettings {
      Subscription = subscription
   });
});

Task("Default")
.Does(() => {
   Information("Hello Cake!");
});

RunTarget(target);