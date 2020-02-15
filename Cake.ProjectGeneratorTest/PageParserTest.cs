using Cake.AzCliParser;
using Cake.ProjectGenerator.Test.Resources;
using NUnit.Framework;
using Shouldly;
using System.Collections.Generic;

namespace Cake.ProjectGeneratorTest
{
    public class AzCliParserServiceTest
    {
        [Test]
        public void Test_Command()
        {
            var azCliParserService = new AzCliParserService();
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
                            new NameValue("--password -p", "Credentials like user password")
                        }
                    }
                }
            };
            var cliCommand = azCliParserService.ParseCliCommand(parsedPage);
            cliCommand.Name.ShouldBe("az login");
        }

        [Test]
        public void Test_Group()
        {
            var azCliParserService = new AzCliParserService();
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
            var cliGroup = azCliParserService.ParseCliGroup(parsedPage);
            cliGroup.Name.ShouldBe("az aks");
        }

        public class PageParserTest
        {
            [Test]
            public void TestAzLogin()
            {
                var azLogin = ResourceManager.GetAzLogin();
                var pageParser = new PageParser();
                var parsedPage = pageParser.ParsePage(azLogin);
                parsedPage.Headers.Count.ShouldBe(6);

                var commandHeader = parsedPage.Headers[0];
                commandHeader.Title.ShouldBe("Command");
                commandHeader.NameValues.Count.ShouldBe(1);

                var parsedPageHeader = parsedPage.Headers[1];
                parsedPageHeader.Title.ShouldBe("Arguments");
                parsedPageHeader.NameValues.Count.ShouldBe(7);
                var allowNoSubscriptions = parsedPageHeader.NameValues[0];
                allowNoSubscriptions.Name.ShouldBe("--allow-no-subscriptions");
                allowNoSubscriptions.Value.ShouldBe(
                    "Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.");
                var password = parsedPageHeader.NameValues[1];
                password.Name.ShouldBe("--password -p");
                password.Value.ShouldBe(
                    "Credentials like user password, or for a service principal, provide client secret or a pem file with key and public certificate. Will prompt if not given.");

                var pageHeader = parsedPage.Headers[4];
                pageHeader.Title.ShouldBe("Examples");
                pageHeader.NameValues.Count.ShouldBe(0);
                pageHeader.TextBlocks.Count.ShouldBe(6);
                pageHeader.TextBlocks[0].Text.ShouldBe("Log in interactively.");
                pageHeader.TextBlocks[0].NestedText.Text.ShouldBe("az login");
                pageHeader.TextBlocks[1].Text
                    .ShouldBe(
                        "Log in with user name and password. This doesn't work with Microsoft accounts or accounts that have two-factor authentication enabled.");
                pageHeader.TextBlocks[1].NestedText.Text.ShouldBe("az login -u johndoe@contoso.com -p VerySecret");
                pageHeader.TextBlocks[2].Text.ShouldBe("Log in with a service principal using client secret.");
                pageHeader.TextBlocks[2].NestedText.Text.ShouldBe(
                    "az login --service-principal -u http://azure-cli-2016-08-05-14-31-15 -p VerySecret --tenant contoso.onmicrosoft.com");
            }
        }
    }
}