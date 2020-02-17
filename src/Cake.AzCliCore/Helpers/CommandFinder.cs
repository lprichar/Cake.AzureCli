using Cake.AzCli.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cake.AzCli.Core.Helpers
{
    public class CommandFinder
    {
        public List<CliCommand> GetAllCliCommands(CliProgram cliProgram)
        {
            var cliCommands = new List<CliCommand>();
            GetAllCliCommands(cliProgram.RootCommand, cliCommands);
            return cliCommands.OrderBy(i => i.Parents).ThenBy(i => i.Name).ToList();
        }

        private void GetAllCliCommands(CliGroup cliGroup, List<CliCommand> cliCommands)
        {
            foreach (var subGroup in cliGroup.Subgroups)
            {
                GetAllCliCommands(subGroup, cliCommands);
            };
            cliCommands.AddRange(cliGroup.Commands);
        }
    }
}
