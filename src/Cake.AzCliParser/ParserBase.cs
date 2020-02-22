using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cake.AzCliParser
{
    public abstract class ParserBase
    {
        protected readonly ILogger _logger;

        protected ParserBase(ILogger logger)
        {
            _logger = logger;
        }

        public bool ParseTag(ref string name, string tag)
        {
            bool containsTag = name.Contains(tag);
            if (containsTag)
            {
                name = name.Replace(tag, "").Trim();
            }

            return containsTag;
        }

        protected void LogWarnUnexpectedSections(ParsedPage parsedPage, string sectionName, List<string> expectedSections)
        {
            var unexpectedSections = parsedPage.Headers
                .Select(h => h.Title)
                .Where(t => !IsExpectedSection(t, expectedSections));
            foreach (var unexpectedSection in unexpectedSections)
            {
                _logger.Warn($"Unexpected section {unexpectedSection} in {sectionName}");
            }
        }

        public static bool IsExpectedSection(string h, List<string> expectedSections)
        {
            return expectedSections.Any(es => Regex.IsMatch(h, es));
        }
    }
}