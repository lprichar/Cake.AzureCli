using Cake.AzCli.Core.Helpers;
using Cake.AzCli.Core.Models;
using NUnit.Framework;
using Shouldly;

namespace Cake.AzCliParser.Test
{
    public class CommandNameMakerTest
    {
        [Test]
        public void GivenCliCommandWithDashesInName_WhenMakeName_ItIsTitleCaseWithNoDashes()
        {
            var commandNameMaker = new CommandNameMaker();
            var name = commandNameMaker.MakeName(new CliCommand
            {
                Name = "get-access-token",
                Parents = "az account"
            });
            name.ShouldBe("AzAccountGetAccessToken");
        }

        [Test]
        public void GivenCliCommandWithDashesInParentNames_WhenMakeName_ItIsTitleCaseWithNoDashes()
        {
            var commandNameMaker = new CommandNameMaker();
            var name = commandNameMaker.MakeName(new CliCommand
            {
                Name = "add",
                Parents = "az account management-group subscription"
            });

            name.ShouldBe("AzAccountManagementGroupSubscriptionAdd");
        }
    }
}
