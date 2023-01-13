# Cake.AzureCli
A [Cake](http://cakebuild.net) plugin that provides strongly typed, fully intellisense documented, and cross platform access
to all 2,833 Azure CLI commands and their 32,669 individual settings.

# Usage

Reference with:

`#addin "nuget:?package=Cake.AzureCli&version=1.3.0"`

All Az commands are accessed with `Az()` and then dot separated groups and a command all in Pascal case e.g. `az group deployment operation list` on the cli is accessed like  `Az().Group.Deployment.Operation.List()` in Cake.AzureCli.

```csharp
// "'az login' is accessed via Az().Login()
dynamic result = Az().Login(new LoginSettings {
   Username = username,
   // all commands can be customized if necessary with a ProcessArgumentBuilder
   Arguments = new ProcessArgumentBuilder()
      // anything appended with .AppendSecret() will be rendered as [REDACTED] if cake is run with `-verbosity=diagnostic`
      .Append("--password").AppendSecret(password)
});

// if azure commands result in json they are converted to dynamic objects
Information("1st tenant = " + result[0].tenantId);

// 'az account set' is accessed with Az().Account.Set()
Az().AccountSet(new AccountSetSettings {
   Subscription = subscription
});
```
