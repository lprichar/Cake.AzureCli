using Cake.AzCli.Core.Models;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Cake.AzCli.Core.Helpers
{
    public class NameMaker
    {
        public string MakeCliGroupType(CliGroup cliGroup)
        {
            var combined = cliGroup.Parents + " " + cliGroup.Name;
            return MakeName(combined) + "CliGroup";
        }

        public string MakeCliGroupName(CliGroup cliGroup)
        {
            return MakeName(cliGroup.Name);
        }

        public string MakeCategory(CliCommand cliCommand)
        {
            return MakeName(cliCommand.Parents);
        }

        public string MakeName(CliArgument argument)
        {
            if (argument?.Name == null) return null;
            return MakeName(argument.Name);
        }

        public string MakeCommandName(CliCommand cliCommand)
        {
            if (cliCommand?.Name == null) return null;
            return MakeName(cliCommand.Name);
        }

        public string MakeCommandSettings(CliCommand cliCommand)
        {
            if (cliCommand?.Name == null) return null;
            var combined = cliCommand.Parents + " " + cliCommand.Name;
            return MakeName(combined) + "Settings";
        }

        private static string MakeName(string combined)
        {
            combined = combined.Replace("-", " ");
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            var name = textInfo.ToTitleCase(combined).Replace(" ", "");
            if (Regex.IsMatch(name, "^[0-9]"))
            {
                // for lack of a better solution
                return "A" + name;
            }
            return name;
        }
    }
}
