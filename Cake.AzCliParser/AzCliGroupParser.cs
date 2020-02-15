using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Cake.AzCliParser
{
    public class AzCliGroupParser
    {
        public CliGroup ParseCliGroup(ParsedPage parsedPage)
        {
            Debug.Assert(parsedPage.Headers[0].Title == "Group");

            var subgroups = GetSubgroups(parsedPage);
            var commands = GetCommands(parsedPage);

            return new CliGroup
            {
                Name = parsedPage.Headers[0].NameValues[0].Name,
                Description = parsedPage.Headers[0].NameValues[0].Value,
                Subgroups = subgroups,
                Commands = commands
            };
        }

        private List<CliCommand> GetCommands(ParsedPage parsedPage)
        {
            var commandsHeader = parsedPage.Headers.FirstOrDefault(i => i.Title == "Commands:");
            if (commandsHeader == null) return new List<CliCommand>();

            return commandsHeader.NameValues
                .Select(MakeCommand)
                .ToList();
        }

        private static CliCommand MakeCommand(NameValue nv)
        {
            var name = nv.Name;
            var isPreview = name.Contains("[Preview]");
            if (isPreview)
            {
                name = name.Replace("[Preview]", "").Trim();
            }
            return new CliCommand
            {
                Name = name,
                ShortDescription = nv.Value,
                IsPreview = isPreview
            };
        }

        private static List<CliGroup> GetSubgroups(ParsedPage parsedPage)
        {
            var subgroups = parsedPage.Headers.FirstOrDefault(i => i.Title == "Subgroups:");
            if (subgroups == null) return new List<CliGroup>();
            return subgroups.NameValues
                .Select(nv => new CliGroup()
                {
                    Name = nv.Name,
                    Description = nv.Value,
                    Commands = new List<CliCommand>()
                })
                .ToList();
        }
    }
}