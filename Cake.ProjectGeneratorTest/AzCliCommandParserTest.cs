using Cake.AzCliParser;
using NUnit.Framework;
using Shouldly;
using System.Collections.Generic;

namespace Cake.ProjectGenerator.Test
{
    public class AzCliCommandParserTest
    {
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

            // ACT
            var azCliParserService = new AzCliCommandParser();
            var cliCommand = azCliParserService.ParseCliCommand(parsedPage);

            // ASSERT
            cliCommand.Name.ShouldBe("az login");
            cliCommand.Description.ShouldBe("Log in to Azure");
            cliCommand.Arguments.Count.ShouldBe(2);
            var firstArgument = cliCommand.Arguments[0];
            firstArgument.Name.ShouldBe("--allow-no-subscriptions");
            firstArgument.Description.ShouldBe("Support access tenants without subscriptions.");
            firstArgument.Required.ShouldBeFalse();
            var secondArgument = cliCommand.Arguments[1];
            secondArgument.Name.ShouldBe("--password");
            secondArgument.ShortName.ShouldBe("-p");
            secondArgument.Description.ShouldBe("Credentials like user password");
            secondArgument.Required.ShouldBeTrue();
        }

    }
}