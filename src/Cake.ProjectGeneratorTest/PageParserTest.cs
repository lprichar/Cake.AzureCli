using Cake.ProjectGenerator.Test.Resources;
using NUnit.Framework;
using Shouldly;

namespace Cake.AzCliParser.Test
{
    public class AzCliParserServiceTest
    {
        public class PageParserTest
        {
            [Test]
            public void TestAzAksInstallConnector()
            {
                // ARRANGE
                var azAksInstallConnector = ResourceManager.GetAzAksInstallConnector();
                var pageParser = new PageParser();

                // ACT
                var parsedPage = pageParser.ParseString(azAksInstallConnector);

                // ASSERT
                parsedPage.Headers[0].Title.ShouldBe("Command");
                parsedPage.Headers[0].NameValues.Count.ShouldBe(1);
                parsedPage.Headers[0].NameValues[0].Name.ShouldBe("az aks install-connector");
                parsedPage.Headers[0].NameValues[0].Value.ShouldBe("Install the ACI Connector on a managed Kubernetes cluster. This command is in preview. It may be changed/removed in a future release.");
            }

            [Test]
            public void TestAzLogin()
            {
                // ARRANGE
                var azLogin = ResourceManager.GetAzLogin();
                var pageParser = new PageParser();

                // ACT
                var parsedPage = pageParser.ParseString(azLogin);

                // ASSERT
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