using Cake.AzCli.Core.Helpers;
using Cake.AzCli.Core.Models;
using NUnit.Framework;
using Shouldly;

namespace Cake.AzCliParser.Test
{
    public class CommandNameMakerTest
    {
        [Test]
        public void GivenArgumentStartsWithNumber_WhenMakeName_ItIsPrefixedWithA()
        {
            var commandNameMaker = new NameMaker();
            var cliArgument = new CliArgument
            {
                Name = "404Document"
            };
            var makeName = commandNameMaker.MakeName(cliArgument);
            // for lack of a better solution
            makeName.ShouldBe("A404Document");
        }

        [Test]
        public void GivenCliCommandWithDashesInName_WhenMakeName_ItIsTitleCaseWithNoDashes()
        {
            var commandNameMaker = new NameMaker();
            var name = commandNameMaker.MakeCommandName(new CliCommand
            {
                Name = "get-access-token",
                Parents = "az account"
            });
            name.ShouldBe("GetAccessToken");
        }

        [Test]
        public void GivenCliCommandWithDashesInParentNames_WhenMakeName_ItIsTitleCaseWithNoDashesMinusAz()
        {
            var commandNameMaker = new NameMaker();
            var name = commandNameMaker.MakeCommandName(new CliCommand
            {
                Name = "add",
                Parents = "az account management-group subscription"
            });

            name.ShouldBe("Add");
        }
    }
}
