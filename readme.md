# Cake.Azure
A [Cake](http://cakebuild.net) plugin that provides strongly typed, fully intellisense documented, and cross platform access
to all 2,833 Azure CLI commands and their 32,669 individual settings.

# Implementation Details

## Az Cli Parser

Naturally a project of this scope couldn't (and shouldn't for maintainability sake) be written by hand.  The project `Cake.AzCliParser` parses through the helpfiles of every command and namespace in the Az CLI and outputs them to a very large JSON file (Cake.AzureCli/AzCliHelpOutput.json, which is over 300K lines uncompressed).
Consequently as Az CLI gets updated it should be trivial to update it.

## T4 Templates

The Cake.AzureCli project contains two T4 templates that generate the actual Cake extension methods and the parameter classes.  These files read the json file and each write a large file on each save.

# Usage

Reference with:

`#addin "nuget:?package=Cake.AzureCli&version=1.0.0"`

All Az commands are accessed with `Az()` and the remainder of the command in Pascal case e.g. `az account set` is accessed like `Az().AccountSet(new AccountSetSettings{...})`. 

```csharp
// "'az login' is accessed via AzLogin. Arguments can be customized if necessary with as ProcessArgumentBuilder
dynamic result = Az().Login(new LoginSettings {
   Username = username,
   Arguments = new ProcessArgumentBuilder()
      .Append("--password").AppendSecret(password)
});

// If azure commands result in json (typically) they are converted to dynamic objects
Information("1st tenant = " + result[0].tenantId);

// 'az account set' is accessed with AzAccountSet
Az().AccountSet(new AccountSetSettings {
   Subscription = subscription
});
```

See /example/build.cake for sample dll reference usage.
