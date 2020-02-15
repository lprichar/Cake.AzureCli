using System.Collections.Generic;
using Cake.AzCliParser;
using NUnit.Framework;
using Shouldly;

namespace Cake.ProjectGenerator.Test
{
    public class AzCliGroupParserTest
    {
        [Test]
        public void ParseCliGroupTest()
        {
            // ARRANGE
            var azCliParserService = new AzCliGroupParser();
            var parsedPage = new ParsedPage
            {
                Headers = new List<PageHeader>
                {
                    new PageHeader("Group")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("az aks", "Commands to manage node pools in Kubernetes kubernetes cluster.")
                        },
                    },
                    new PageHeader("Subgroups:")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("nodepool", "Commands to manage node pools in Kubernetes kubernetes cluster."),
                        }
                    },
                    new PageHeader("Commands:")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("browse", "Show the dashboard for a Kubernetes cluster in a web browser."),
                            new NameValue("install-connector [Preview]", "Install the ACI Connector on a managed Kubernetes cluster."),
                        }
                    }
                }
            };

            // ACT
            var cliGroup = azCliParserService.ParseCliGroup(parsedPage);

            // ASSERT
            cliGroup.Name.ShouldBe("az aks");
            cliGroup.Description.ShouldBe("Commands to manage node pools in Kubernetes kubernetes cluster.");
            var subGroup = cliGroup.Subgroups.ShouldHaveSingleItem();
            subGroup.Name.ShouldBe("nodepool");
            subGroup.Description.ShouldBe("Commands to manage node pools in Kubernetes kubernetes cluster.");
            subGroup.Commands.Count.ShouldBe(2);
            var firstCommand = subGroup.Commands[0];
            firstCommand.Name.ShouldBe("browse");
            firstCommand.Description.ShouldBe("Show the dashboard for a Kubernetes cluster in a web browser.");
            firstCommand.Preview.ShouldBeFalse();
            var secondCommand = subGroup.Commands[1];
            secondCommand.Name.ShouldBe("install-connector");
            secondCommand.Description.ShouldBe("Install the ACI Connector on a managed Kubernetes cluster.");
            secondCommand.Preview.ShouldBeTrue();
        }

    }
}