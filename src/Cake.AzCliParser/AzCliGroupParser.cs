using Cake.AzCli.Core.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Cake.AzCliParser
{
    public class AzCliGroupParser : ParserBase
    {
        public static readonly List<string> GroupExpectedSections = new List<string> { "^Group$", "^Commands:$", "^Subgroups:$", "^Please let us know how we are doing" };

        public AzCliGroupParser(ILogger logger) : base(logger) { }

        public CliGroup ParsePage(ParsedPage parsedPage)
        {
            Debug.Assert(parsedPage.Headers[0].Title == "Group");

            var subgroups = GetSubgroups(parsedPage);
            var commands = GetCommands(parsedPage);

            var nameDescription = ParseNameAndDescription(parsedPage);

            LogWarnUnexpectedSections(parsedPage, nameDescription.Name, GroupExpectedSections);

            return new CliGroup
            {
                Name = nameDescription.Name,
                Description = nameDescription.Description,
                Subgroups = subgroups,
                Commands = commands
            };
        }

        private static (string Name, string Description) ParseNameAndDescription(ParsedPage parsedPage)
        {
            Debug.Assert(parsedPage.Headers.Count > 0);
            var firstHeader = parsedPage.Headers[0];
            if (firstHeader.TextBlocks.Any()) return (firstHeader.TextBlocks[0].Text, null);
            return (firstHeader.NameValues[0].Name, firstHeader.NameValues[0].Value);
        }

        private List<CliCommand> GetCommands(ParsedPage parsedPage)
        {
            var commandsHeader = parsedPage.Headers.FirstOrDefault(i => i.Title == "Commands:");
            if (commandsHeader == null) return new List<CliCommand>();

            return commandsHeader.NameValues
                .Select(MakeCommand)
                .ToList();
        }

        private CliCommand MakeCommand(NameValue nv)
        {
            var name = nv.Name;
            var isPreview = ParseTag(ref name, "[Preview]");
            var isDeprecated = ParseTag(ref name, "[Deprecated]");
            return new CliCommand
            {
                Name = name,
                IsDeprecated = isDeprecated,
                ShortDescription = nv.Value,
                IsPreview = isPreview
            };
        }

        private List<CliGroup> GetSubgroups(ParsedPage parsedPage)
        {
            var subgroups = parsedPage.Headers.FirstOrDefault(i => i.Title == "Subgroups:");
            if (subgroups == null) return new List<CliGroup>();

            return subgroups.NameValues
                .Select(ParsePage)
                .ToList();
        }

        private CliGroup ParsePage(NameValue nv)
        {
            var name = nv.Name;

            var isPreview = ParseTag(ref name, "[Preview]");
            var isDeprecated = ParseTag(ref name, "[Deprecated]");

            return new CliGroup()
            {
                Name = name,
                Description = nv.Value,
                Commands = new List<CliCommand>(),
                IsPreview = isPreview,
                IsDeprecated = isDeprecated
            };
        }
    }
}