﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Cake.AzCliParser
{
    public class AzCliGroupParser
    {
        private static readonly List<string> ExpectedSections = new List<string> { "Group", "Commands:", "Subgroups:" };
        private readonly Logger _logger;

        public AzCliGroupParser()
        {
            _logger = new Logger();
        }

        public CliGroup ParsePage(ParsedPage parsedPage)
        {
            Debug.Assert(parsedPage.Headers[0].Title == "Group");

            var subgroups = GetSubgroups(parsedPage);
            var commands = GetCommands(parsedPage);

            var nameDescription = ParseNameAndDescription(parsedPage);

            var unexpectedSections = parsedPage.Headers.Where(h => !ExpectedSections.Contains(h.Title));
            foreach (var unexpectedSection in unexpectedSections)
            {
                _logger.Warn($"Unexpected section {unexpectedSection.Title} in {nameDescription.Name}");
            }

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
                .Select(ParsePage)
                .ToList();
        }

        private static CliGroup ParsePage(NameValue nv)
        {
            var name = nv.Name;

            var isPreview = name.Contains("[Preview]");
            if (isPreview)
            {
                name = name.Replace("[Preview]", "").Trim();
            }

            return new CliGroup()
            {
                Name = name,
                Description = nv.Value,
                Commands = new List<CliCommand>(),
                IsPreview = isPreview
            };
        }
    }
}