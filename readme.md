# Cake.Azure
A [Cake](http://cakebuild.net) plugin that provides strongly typed and fully intellisense documented access
to all 2,833 Azure CLI commands and their 32,669 individual settings.

# Implementation Details

## Az Cli Parser

Naturally a project of this scope couldn't (and shouldn't for maintainability sake) be written by hand.  The project `Cake.AzCliParser` parses through the helpfiles of every command and namespace in the Az CLI and outputs them to a very large JSON file (Cake.AzureCli/AzCliHelpOutput.json, which is over 300K lines uncompressed).
Consequently as Az CLI gets updated it should be trivial to update it.

## T4 Templates

The Cake.AzureCli project contains two T4 templates that generate the actual Cake extension methods and the parameter classes.  These files read the json file and each write a large file on each save.

# Usage

Note, I haven't published this to nuget yet

All Az commands are accessed via Pascal case e.g. `az login` is accessed like `AzLogin(new AzLoginSettings{...})`. 

```csharp
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
```

See /example/build.cake for sample dll reference usage.


<!--
```csharp
#addin "nuget:?package=Microsoft.Rest.ClientRuntime&version=2.3.21"
#addin "nuget:?package=Microsoft.Rest.ClientRuntime.Azure.Authentication&version=2.4.0"
#addin "nuget:?package=Microsoft.IdentityModel.Clients.ActiveDirectory&version=4.3.0"
#addin "nuget:?package=Microsoft.Azure.Management.ResourceManager&version=2.4.5-preview&prerelease"
#addin "nuget:?package=Microsoft.Rest.ClientRuntime.Azure&version=3.3.19"
#addin "nuget:?package=Cake.Azure&version=0.4.0"
```
-->

<!-- 
## Aliases

Please visit the Cake Documentation for a list of available aliases:

[http://cakebuild.net/dsl/azure/](http://cakebuild.net/dsl/azure) 
-->
