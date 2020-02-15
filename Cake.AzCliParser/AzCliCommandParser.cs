using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cake.AzCliParser
{
    public class AzCliCommandParser
    {
        private static readonly List<string> ExpectedSections = new List<string> { "Command", "Arguments", "Network Rule Arguments", "Global Arguments", "Examples" };
        private readonly Logger _logger;

        public AzCliCommandParser()
        {
            _logger = new Logger();
        }

        public CliCommand ParsePage(ParsedPage parsedPage)
        {
            Debug.Assert(parsedPage.Headers[0].Title == "Command");

            var arguments = GetArguments(parsedPage);
            var examples = GetExamples(parsedPage);

            var unexpectedSections = parsedPage.Headers.Where(h => !ExpectedSections.Contains(h.Title));
            var name = parsedPage.Headers[0].NameValues[0].Name;

            foreach (var unexpectedSection in unexpectedSections)
            {
                _logger.Warn($"Unexpected section {unexpectedSection.Title} in {name}");
            }

            return new CliCommand
            {
                Name = name,
                ShortDescription = parsedPage.Headers[0].NameValues[0].Value,
                Arguments = arguments,
                Examples = examples
            };
        }

        private List<CliExample> GetExamples(ParsedPage parsedPage)
        {
            var examplesSection = parsedPage.Headers.FirstOrDefault(i => i.Title == "Examples");
            if (examplesSection == null) return new List<CliExample>();
            return examplesSection.TextBlocks
                .Select(tb => new CliExample
                {
                    Description = tb.Text,
                    Example = tb.NestedText?.Text
                })
                .ToList();
        }

        private List<CliArgument> GetArguments(ParsedPage parsedPage)
        {
            var arguments = GetSectionNameValuesOrDefault(parsedPage, "Arguments");
            var globalArguments = GetSectionNameValuesOrDefault(parsedPage, "Global Arguments");
            var networkRuleArguments = GetSectionNameValuesOrDefault(parsedPage, "Network Rule Arguments");

            var allArguments = arguments
                .Concat(networkRuleArguments)
                .Concat(globalArguments);
            return allArguments
                .Select(ParseArgument)
                .ToList();
        }

        private static List<NameValue> GetSectionNameValuesOrDefault(ParsedPage parsedPage, string title)
        {
            var section = parsedPage.Headers.FirstOrDefault(i => i.Title == title);
            if (section == null) return new List<NameValue>();
            return section.NameValues;
        }

        private CliArgument ParseArgument(NameValue nameValue)
        {
            var name = nameValue.Name;
            var required = name.Contains("[Required]");
            if (required)
            {
                name = name.Replace("[Required]", "").Trim();
            }

            var inPreview = name.Contains("[Preview]");
            if (inPreview)
            {
                name = name.Replace("[Preview]", "").Trim();
            }

            var parts = GetNames(name);
            var allowedValues = ParseAllowedValues(nameValue.Value);

            return new CliArgument
            {
                Name = parts.LongName,
                ShortName = parts.ShortName,
                Description = nameValue.Value,
                Required = required,
                InPreview = inPreview,
                AllowedValues = allowedValues
            };
        }

        private List<string> ParseAllowedValues(string description)
        {
            var allowedValuesRegex = new Regex("Allowed values: ([^\\.]+).");
            var match = allowedValuesRegex.Match(description);
            if (!match.Success) return new List<string>();
            string strAllowedValues = match.Groups[1].Value;
            return strAllowedValues.Split(',')
                .Select(i => i.Trim(',', ' '))
                .ToList();
        }

        private (string LongName, string ShortName) GetNames(string name)
        {
            var parts = name.Split(' ');
            if (parts.Length > 2)
            {
                throw new ArgumentException("Too many arguments can't parse: " + name);
            }

            if (parts.Length == 1)
            {
                return (name, null);
            }

            return (parts[0], parts[1]);
        }
    }
}