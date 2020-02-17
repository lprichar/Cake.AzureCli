using NUnit.Framework;
using Shouldly;
using System.Collections.Generic;

namespace Cake.AzCliParser.Test
{
    public class AzCliCommandParserTest
    {
        [Test]
        public void ParseTrippleArgs()
        {
            // ARRANGE
            var parsedPage = new ParsedPage
            {
                Headers = new List<PageHeader>
                {
                    new PageHeader("Command")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("az deploymentmanager artifact-source create", "Creates an artifact source.")
                        },
                    },
                    new PageHeader("Arguments")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("--artifact-source-name --name -n [Required]", "The name of the artifact source."),
                        }
                    },
                }
            };
            var fakeLogger = new FakeLogger();
            var azCliParserService = new AzCliCommandParser(fakeLogger);

            // ACT
            var cliCommand = azCliParserService.ParsePage(parsedPage);

            // ASSERT
            var argument = cliCommand.Arguments.ShouldHaveSingleItem();
            argument.Name.ShouldBe("--artifact-source-name");
            argument.ShortName.ShouldBe("-n");
            argument.Required.ShouldBeTrue();
        }

        [Test]
        public void ParseAzAcrCreate()
        {
            // ARRANGE
            var parsedPage = new ParsedPage
            {
                Headers = new List<PageHeader>
                {
                    new PageHeader("Command")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("az acr create", "Creates an Azure Container Registry")
                        },
                    },
                    new PageHeader("Arguments")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("--workspace          [Preview]", "Name or ID of the Log Analytics workspace"),
                        }
                    },
                    new PageHeader("Network Rule Arguments")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("--default-action", "Default action to apply when no rule matches. Only applicable to Premium SKU.  Allowed values: Allow, Deny.")
                        }
                    },
                    new PageHeader("Global Arguments")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("--output -o", "Output format.  Allowed values: json, jsonc, none, table, tsv, yaml.  Default: json.")
                        }
                    },
                }
            };
            var fakeLogger = new FakeLogger();
            var azCliParserService = new AzCliCommandParser(fakeLogger);

            // ACT
            var cliCommand = azCliParserService.ParsePage(parsedPage);

            // ASSERT
            cliCommand.Name.ShouldBe("az acr create");
            cliCommand.ShortDescription.ShouldBe("Creates an Azure Container Registry");
            cliCommand.Arguments.Count.ShouldBe(3);
            var firstArgument = cliCommand.Arguments[0];
            firstArgument.Name.ShouldBe("--workspace");
            firstArgument.ShortName.ShouldBeNull();
            firstArgument.InPreview.ShouldBeTrue();
            firstArgument.Description.ShouldBe("Name or ID of the Log Analytics workspace");
            firstArgument.Required.ShouldBeFalse();
            firstArgument.AllowedValues.ShouldBeEmpty();

            var secondArgument = cliCommand.Arguments[1];
            secondArgument.Name.ShouldBe("--default-action");
            secondArgument.InPreview.ShouldBeFalse();
            secondArgument.Required.ShouldBeFalse();

            var thirdArgument = cliCommand.Arguments[2];
            thirdArgument.Name.ShouldBe("--output");
            thirdArgument.ShortName.ShouldBe("-o");
            thirdArgument.Description.ShouldBe("Output format.  Allowed values: json, jsonc, none, table, tsv, yaml.  Default: json.");
            thirdArgument.AllowedValues.Count.ShouldBe(6);
            thirdArgument.AllowedValues.ShouldContain("jsonc");
            thirdArgument.AllowedValues.ShouldContain("json");
            thirdArgument.AllowedValues.ShouldContain("none");
            thirdArgument.AllowedValues.ShouldContain("table");
            thirdArgument.AllowedValues.ShouldContain("tsv");
            thirdArgument.AllowedValues.ShouldContain("yaml");
            thirdArgument.Required.ShouldBeFalse();
        }

        [Test]
        public void ParseCliCommandTest()
        {
            // ARRANGE
            var parsedPage = new ParsedPage
            {
                Headers = new List<PageHeader>
                {
                    new PageHeader("Command")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("az login", "Log in to Azure")
                        },
                    },
                    new PageHeader("Arguments")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("--allow-no-subscriptions", "Support access tenants without subscriptions."),
                            new NameValue("--password -p [Required]", "Credentials like user password")
                        }
                    },
                    new PageHeader("Global Arguments")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("--debug", "Increase logging verbosity to show all debug logs.")
                        }
                    },
                    new PageHeader("Examples")
                    {
                        TextBlocks = new List<TextBlock>
                        {
                            new TextBlock("Install the virtual Kubelet using a specific service principal in a specific resource group.")
                            {
                                NestedText = new TextBlock("az aks install-connector --name MyManagedCluster --resource-group MyResourceGroup")
                            }
                        }
                    }
                }
            };
            var fakeLogger = new FakeLogger();
            var azCliParserService = new AzCliCommandParser(fakeLogger);

            // ACT
            var cliCommand = azCliParserService.ParsePage(parsedPage);

            // ASSERT
            cliCommand.Name.ShouldBe("az login");
            cliCommand.ShortDescription.ShouldBe("Log in to Azure");
            cliCommand.Arguments.Count.ShouldBe(3);
            var firstArgument = cliCommand.Arguments[0];
            firstArgument.Name.ShouldBe("--allow-no-subscriptions");
            firstArgument.ShortName.ShouldBeNull();
            firstArgument.Description.ShouldBe("Support access tenants without subscriptions.");
            firstArgument.Required.ShouldBeFalse();

            var secondArgument = cliCommand.Arguments[1];
            secondArgument.Name.ShouldBe("--password");
            secondArgument.ShortName.ShouldBe("-p");
            secondArgument.Description.ShouldBe("Credentials like user password");
            secondArgument.Required.ShouldBeTrue();

            var thirdArgument = cliCommand.Arguments[2];
            thirdArgument.Name.ShouldBe("--debug");
            thirdArgument.ShortName.ShouldBeNull();
            thirdArgument.Description.ShouldBe("Increase logging verbosity to show all debug logs.");
            thirdArgument.Required.ShouldBeFalse();

            var example = cliCommand.Examples.ShouldHaveSingleItem();
            example.Description.ShouldBe("Install the virtual Kubelet using a specific service principal in a specific resource group.");
            example.Example.ShouldBe("az aks install-connector --name MyManagedCluster --resource-group MyResourceGroup");
        }

    }
}