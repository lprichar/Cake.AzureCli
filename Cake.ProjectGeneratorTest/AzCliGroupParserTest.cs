using Cake.AzCliParser;
using NUnit.Framework;
using Shouldly;
using System.Collections.Generic;

namespace Cake.ProjectGenerator.Test
{
    public class AzCliGroupParserTest
    {
        [Test]
        public void ParseAzGroupTest()
        {
            // ARRANGE
            var azCliParserService = new AzCliGroupParser();
            var parsedPage = new ParsedPage
            {
                Headers = new List<PageHeader>
                {
                    new PageHeader("Group")
                    {
                        TextBlocks = new List<TextBlock>
                        {
                            new TextBlock("az")
                        }
                    },
                    new PageHeader("Subgroups:")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("ams               [Preview]", "Manage Azure Media Services resources."),
                        }
                    },
                    new PageHeader("Commands:")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("interactive    [Preview]", "Start interactive mode. Installs the Interactive extension if not installed already."),
                        }
                    }
                }
            };

            // ACT
            var cliGroup = azCliParserService.ParseCliGroup(parsedPage);

            // ASSERT
            cliGroup.Name.ShouldBe("az");

            var amsSubgroup = cliGroup.Subgroups.ShouldHaveSingleItem();
            amsSubgroup.Name.ShouldBe("ams");
            amsSubgroup.IsPreview.ShouldBeTrue();

            var interactiveCommand = cliGroup.Commands.ShouldHaveSingleItem();
            interactiveCommand.Name.ShouldBe("interactive");
            interactiveCommand.IsPreview.ShouldBeTrue();
        }

        [Test]
        public void ParseAzAksGroupTest()
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
            subGroup.Commands.Count.ShouldBe(0);
            cliGroup.Commands.Count.ShouldBe(2);
            var firstCommand = cliGroup.Commands[0];
            firstCommand.Name.ShouldBe("browse");
            firstCommand.ShortDescription.ShouldBe("Show the dashboard for a Kubernetes cluster in a web browser.");
            firstCommand.IsPreview.ShouldBeFalse();
            var secondCommand = cliGroup.Commands[1];
            secondCommand.Name.ShouldBe("install-connector");
            secondCommand.ShortDescription.ShouldBe("Install the ACI Connector on a managed Kubernetes cluster.");
            secondCommand.IsPreview.ShouldBeTrue();
        }

    }
}