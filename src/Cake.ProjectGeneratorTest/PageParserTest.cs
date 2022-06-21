using Cake.ProjectGenerator.Test.Resources;
using Microsoft.VisualBasic;

using NUnit.Framework;
using Shouldly;
using System;
using System.Linq;

namespace Cake.AzCliParser.Test
{
    public class AzCliParserServiceTest
    {
        public class PageParserTest
        {
            [Test]
            public void GivenLineHasColonAndNotIndentedMuch_WhenDeterminingIsNameValuePair_ThenItIs()
            {
                var line = "                                                          {\"ServiceTypeName\" : \"MaxPercentUnhealthyP";
                var isNameValuePair = PageParser.IsNameValuePair(line);
                isNameValuePair.ShouldBeFalse();
            }

            [Test]
            public void GivenLineHasColonButIndentedPrettyFar_WhenDeterminingIsNameValuePair_ThenItIsNot()
            {
                var line = "    --service-type-health-policy-map                    : Specify the map of the health policy to";
                var isNameValuePair = PageParser.IsNameValuePair(line);
                isNameValuePair.ShouldBeTrue();
            }

            [Test]
            public void TestAzSfApplicationUpdate_ColonsInDescriptionAreNotNewNameValuePairs()
            {
                // ARRANGE
                var azSfApplicationUpdate = ResourceManager.GetAzSfApplicationUpdate();
                var pageParser = new PageParser();

                // ACT
                var parsedPage = pageParser.ParseString(azSfApplicationUpdate);

                // ASSERT
                var argumentSection = parsedPage.Headers.FirstOrDefault(i => i.Title == "Arguments");
                argumentSection.ShouldNotBeNull();
                argumentSection.NameValues.Count.ShouldBe(9);
                var policyMap = argumentSection.NameValues.FirstOrDefault(i => i.Name == "--service-type-health-policy-map");
                policyMap.ShouldNotBeNull();
                policyMap.Value.ShouldStartWith("Specify the map of the health policy ");
                Console.WriteLine(policyMap.Value);
                policyMap.Value.ShouldEndWith("}. ");
            }


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
                parsedPage.Headers.Count.ShouldBe(7);

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
                pageHeader.TextBlocks[1].Text.ShouldBe(
                        "Log in with user name and password. This doesn't work with Microsoft accounts or accounts that have two-factor authentication enabled. Use -p=secret if the first character of the password is '-'.");
                pageHeader.TextBlocks[1].NestedText.Text.ShouldBe("az login -u johndoe@contoso.com -p VerySecret");
                pageHeader.TextBlocks[2].Text.ShouldBe("Log in with a service principal using client secret. Use -p=secret if the first character of the password is '-'.");
                pageHeader.TextBlocks[2].NestedText.Text.ShouldBe(
                    "az login --service-principal -u http://azure-cli-2016-08-05-14-31-15 -p VerySecret --tenant contoso.onmicrosoft.com");
            }

            [Test]
            public void TestAzAksCreate()
            {
                // ARRANGE
                var azAksCreate = ResourceManager.GetAzAksCreate();
                var pageParser = new PageParser();

                // ACT
                var parsedPage = pageParser.ParseString(azAksCreate);

                // ASSERT
                parsedPage.Headers.Count.ShouldBe(7);

                var commandHeader = parsedPage.Headers[0];
                commandHeader.Title.ShouldBe("Command");
                commandHeader.NameValues.Count.ShouldBe(1);

                var argumentsHeader = parsedPage.Headers[1];
                argumentsHeader.Title.ShouldBe("Arguments");
                argumentsHeader.NameValues.Count.ShouldBe(95);

                var appGatewayArgumentsHeader = parsedPage.Headers[2];
                appGatewayArgumentsHeader.Title.ShouldBe("Application Gateway Arguments");
                appGatewayArgumentsHeader.NameValues.Count.ShouldBe(5);

                var globalArgumentsHeader = parsedPage.Headers[3];
                globalArgumentsHeader.Title.ShouldBe("Global Arguments");
                globalArgumentsHeader.NameValues.Count.ShouldBe(7);


                var enableAddonsOption = argumentsHeader.NameValues.FirstOrDefault(x => x.Name == "--enable-addons -a");
                enableAddonsOption.ShouldNotBeNull();
                enableAddonsOption.Value.ShouldContain("- http_application_routing : configure ingress with automatic public DNS name creation.");
            }

            [Test]
            public void TestWebappConnectionUpdatePostgresFlexible()
            {
                // ARRANGE
                var azAksCreate = ResourceManager.GetWebappConnectionUpdatePostgresFlexible();
                var pageParser = new PageParser();

                // ACT
                var parsedPage = pageParser.ParseString(azAksCreate);

                // ASSERT
                var commandHeader = parsedPage.Headers.FirstOrDefault(h => h.Title == "AuthType Arguments");
                commandHeader.ShouldNotBeNull();
                var argument = commandHeader.NameValues.ShouldHaveSingleItem();
                argument.Name.ShouldBe("--secret");
                argument.Value.ShouldContain("secret-name : One of <secret, secret-uri, secret-name> is required.");
            }
        }
    }
}