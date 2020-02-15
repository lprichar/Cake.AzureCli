using System.Diagnostics;

namespace Cake.AzCliParser
{
    public class AzCliParserService
    {
        public CliGroup ParseCliGroup(ParsedPage parsedPage)
        {
            Debug.Assert(parsedPage.Headers[0].Title == "Group");
            return new CliGroup
            {
                Name = parsedPage.Headers[0].NameValues[0].Name
            };
        }

        public CliCommand ParseCliCommand(ParsedPage parsedPage)
        {
            Debug.Assert(parsedPage.Headers[0].Title == "Command");
            return new CliCommand
            {
                Name = parsedPage.Headers[0].NameValues[0].Name
            };
        }
    }
}