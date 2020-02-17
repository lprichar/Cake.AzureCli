using Cake.AzCli.Core.Models;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Cake.AzCli.Core.Helpers
{
    public class CommandNameMaker
    {
        public string MakeCategory(CliCommand cliCommand)
        {
            return MakeName(cliCommand.Parents);
        }

        public string MakeName(CliArgument argument)
        {
            if (argument?.Name == null) return null;
            return MakeName(argument.Name);
        }

        public string MakeName(CliCommand cliCommand)
        {
            if (cliCommand?.Name == null) return null;
            var combined = cliCommand.Parents + " " + cliCommand.Name;
            return MakeName(combined);
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
