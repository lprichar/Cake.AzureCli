using System.Collections.Generic;

namespace Cake.AzCliCore
{
    public class CliCommand
    {
        public string Name { get; set; }
        public string Parents { get; set; }
        public string ShortDescription { get; set; }
        public List<CliArgument> Arguments { get; set; }
        public bool IsPreview { get; set; }
        public List<CliExample> Examples { get; set; }

        public void Merge(CliCommand command)
        {
            Arguments = command.Arguments;
            Examples = command.Examples;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}