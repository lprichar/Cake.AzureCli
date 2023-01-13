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

See /example/build.cake for more examples.

# Implementation Details

## Az Cli Parser

Naturally a project of this scope couldn't (and shouldn't for maintainability sake) be written by hand.  The 
project `Cake.AzCliParser` parses through the helpfiles of every command and namespace in the Az CLI and outputs 
them to a very large JSON file (Cake.AzureCli/AzCliHelpOutput.json, which is over 300K lines uncompressed).
Consequently as Az CLI gets updated it should be trivial to update it.

## T4 Templates

The Cake.AzureCli project contains two T4 templates that generate the actual Cake extension methods and the parameter classes.  These files read the json file and each write a large file on each save.

