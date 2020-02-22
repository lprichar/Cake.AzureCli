using Cake.Core;
using Cake.Core.IO;
using NUnit.Framework;
using Shouldly;
using System.Collections.Generic;

namespace Cake.AzCliParser.Test
{
    public class AzCliGroupParserTest
    {
        [Test]
        public void TestProcessArgumentBuilder()
        {
            var processArgumentBuilder = new ProcessArgumentBuilder();
            processArgumentBuilder.Append("az login");
            processArgumentBuilder.Append("--username").AppendQuoted("bsmith");
            processArgumentBuilder.Append("--password").AppendSecret("secretpassword");
            processArgumentBuilder.RenderSafe().ShouldBe("az login --username \"bsmith\" --password [REDACTED]");
            processArgumentBuilder.Render().ShouldBe("az login --username \"bsmith\" --password secretpassword");
        }

        [Test]
        public void DeprecatedCommand()
        {
            // ARRANGE
            var parsedPage = new ParsedPage
            {
                Headers = new List<PageHeader>
                {
                    new PageHeader("Group")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("az vm image", "Information on available virtual machine images.")
                        }
                    },
                    new PageHeader("Commands:")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("accept-terms [Deprecated]", "Accept Azure Marketplace term so that the image can be used to create VMs.")
                        }
                    }

                }
            };
            var fakeLogger = new FakeLogger();

            // ACT
            var azCliGroupParser = new AzCliGroupParser(fakeLogger);
            var cliGroup = azCliGroupParser.ParsePage(parsedPage);

            // ASSERT
            var command = cliGroup.Commands.ShouldHaveSingleItem();
            command.Name.ShouldBe("accept-terms");
            command.IsDeprecated.ShouldBeTrue();
        }

        [Test]
        public void PleaseLetUsKnowIsExpectedSection()
        {
            ParserBase.IsExpectedSection("Please let us know how we are doing slkjdljslkdjflkj", AzCliGroupParser.GroupExpectedSections).ShouldBeTrue();
        }

        [Test]
        public void ZzzIsUnexpectedSection()
        {
            ParserBase.IsExpectedSection("Zzz", AzCliGroupParser.GroupExpectedSections).ShouldBeFalse();
        }

        [Test]
        public void GroupIsExpectedSection()
        {
            ParserBase.IsExpectedSection("Group", AzCliGroupParser.GroupExpectedSections).ShouldBeTrue();
        }

        [Test]
        public void LogUnexpectedSections()
        {
            // ARRANGE
            var parsedPage = new ParsedPage
            {
                Headers = new List<PageHeader>
                {
                    new PageHeader("Group")
                    {
                        TextBlocks = new List<TextBlock>
                        {
                            new TextBlock("az cli")
                        }
                    },
                    new PageHeader("Zzzzz"),
                }
            };
            var fakeLogger = new FakeLogger();

            // ACT
            var azCliGroupParser = new AzCliGroupParser(fakeLogger);
            azCliGroupParser.ParsePage(parsedPage);

            // ASSERT
            fakeLogger.Messages.ShouldContain("Unexpected section Zzzzz in az cli");
        }

        [Test]
        public void ParseAzCosmosdbDeprecatedSubgroup()
        {
            // ARRANGE
            var azCliParserService = new AzCliGroupParser(new FakeLogger());
            var parsedPage = new ParsedPage
            {
                Headers = new List<PageHeader>
                {
                    new PageHeader("Group")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("az cosmosdb", "Manage Azure Cosmos DB database accounts.")
                        }
                    },
                    new PageHeader("Subgroups:")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("collection  [Deprecated]", "Manage Azure Cosmos DB collections."),
                        }
                    },
                    new PageHeader("Commands:")
                    {
                        NameValues = new List<NameValue>
                        {
                            new NameValue("failover-priority-change", "Changes the failover priority for the Azure Cosmos DB database account."),
                        }
                    }
                }
            };

            // ACT
            var cliGroup = azCliParserService.ParsePage(parsedPage);

            // ASSERT
            cliGroup.Name.ShouldBe("az cosmosdb");

            var amsSubgroup = cliGroup.Subgroups.ShouldHaveSingleItem();
            amsSubgroup.Name.ShouldBe("collection");
            amsSubgroup.IsDeprecated.ShouldBeTrue();
            amsSubgroup.IsPreview.ShouldBeFalse();
        }

        [Test]
        public void ParseAzGroupTest()
        {
            // ARRANGE
            var azCliParserService = new AzCliGroupParser(new FakeLogger());
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
            var cliGroup = azCliParserService.ParsePage(parsedPage);

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
            var fakeLogger = new FakeLogger();
            var azCliParserService = new AzCliGroupParser(fakeLogger);
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
            var cliGroup = azCliParserService.ParsePage(parsedPage);

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

    public class FakeLogger : ILogger
    {
        public List<string> Messages { get; set; } = new List<string>();

        public void Warn(string message)
        {
            Messages.Add(message);
        }

        public void Debug(string message)
        {
            Messages.Add(message);
        }

        public void Error(string message)
        {
            Messages.Add(message);
        }

        public void Dispose()
        {
        }
    }
}