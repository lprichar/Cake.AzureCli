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

            return new CliGroup
            {
                Name = parsedPage.Headers[0].NameValues[0].Name,
                Description = parsedPage.Headers[0].NameValues[0].Value,
                Subgroups = subgroups
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
                    Description = nv.Value
                })
                .ToList();
        }
    }
}