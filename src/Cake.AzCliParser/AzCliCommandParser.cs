using System;
using Cake.AzCli.Core.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cake.AzCliParser
{
    public class AzCliCommandParser : ParserBase
    {
        private static readonly List<string> CommandExpectedSections = new List<string>
        {
            "^Command$",
            "Arguments$",
            "^Examples$",
            "^For more specific examples",
            "^Please let us know how we are doing",
            "^Positional$", // todo: maybe we could generate additional examples from this command, it comes up somewhat frequently
            "^To search AI knowledge base",
        };

        public AzCliCommandParser(ILogger logger) : base(logger) { }

        public CliCommand ParsePage(ParsedPage parsedPage)
        {
            Debug.Assert(parsedPage.Headers[0].Title == "Command");

            var arguments = GetArguments(parsedPage);
            var examples = GetExamples(parsedPage);

            var name = parsedPage.Headers[0].NameValues[0].Name;

            LogWarnUnexpectedSections(parsedPage, name, CommandExpectedSections);

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
            var allArguments = parsedPage.Headers
                .Where(h => h.Title.EndsWith("Arguments"))
                .SelectMany(h => h.NameValues);

            return allArguments
                .Select(ParseArgument)
                .ToList();
        }

        private CliArgument ParseArgument(NameValue nameValue)
        {
            var name = nameValue.Name;

            var required = ParseTag(ref name, "[Required]");
            var inPreview = ParseTag(ref name, "[Preview]");
            var experimental = ParseTag(ref name, "[Experimental]");

            var parts = GetNames(name);
            var allowedValues = ParseAllowedValues(nameValue.Value);

            return new CliArgument
            {
                Name = parts.LongName,
                ShortName = parts.ShortName,
                Description = nameValue.Value,
                Required = required,
                InPreview = inPreview,
                Experimental = experimental,
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
            var parts = name.Split(new[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length > 2)
            {
                _logger.Warn($"Multiple synonyms for command {name}, just using first and last");
                return (parts[0], parts.Last());
            }

            if (parts.Length == 1)
            {
                return (name, null);
            }

            return (parts[0], parts[1]);
        }
    }
}