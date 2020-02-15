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

            return new CliCommand
            {
                Name = parsedPage.Headers[0].NameValues[0].Name,
                Description = parsedPage.Headers[0].NameValues[0].Value,
                Arguments = arguments
            };
        }

        private List<CliArgument> GetArguments(ParsedPage parsedPage)
        {
            var arguments = parsedPage.Headers.FirstOrDefault(i => i.Title == "Arguments");
            if (arguments == null) return new List<CliArgument>();
            return arguments.NameValues
                .Select(ParseArgument)
                .ToList();
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