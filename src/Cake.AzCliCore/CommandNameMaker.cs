using System.Globalization;

namespace Cake.AzCliCore
{
    public class CommandNameMaker
    {
        public string MakeName(CliCommand cliCommand)
        {
            if (cliCommand?.Name == null) return null;
            var combined = cliCommand.Parents + " " + cliCommand.Name;
            combined = combined.Replace("-", " ");
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            return ti.ToTitleCase(combined).Replace(" ", "");
        }
    }
}
