using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Cake.AzCliParser
{
    public class AzCliCommandParser
    {
        public CliCommand ParseCliCommand(ParsedPage parsedPage)
        {
            Debug.Assert(parsedPage.Headers[0].Title == "Command");

            var arguments = GetArguments(parsedPage);
            var examples = GetExamples(parsedPage);

            return new CliCommand
            {
                Name = parsedPage.Headers[0].NameValues[0].Name,
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

            var allArguments = arguments.Concat(globalArguments);
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

            var parts = GetNames(name);

            return new CliArgument
            {
                Name = parts.LongName,
                ShortName = parts.ShortName,
                Description = nameValue.Value,
                Required = required
            };
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