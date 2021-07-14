using System.Collections.Generic;

namespace Cake.AzCli.Core.Models
{
    public class CliGroup
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CliGroup> Subgroups { get; set; }
        public List<CliCommand> Commands { get; set; }
        public bool IsPreview { get; set; }
        public bool IsDeprecated { get; set; }
        public bool IsExperimental { get; set; }
        public string Parents { get; set; }

        public void Merge(CliGroup fullGroup)
        {
            Subgroups = fullGroup.Subgroups;
            Commands = fullGroup.Commands;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}