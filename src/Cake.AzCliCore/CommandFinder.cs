using System.Collections.Generic;

namespace Cake.AzCliCore
{
    public class CommandFinder
    {
        public List<CliCommand> GetAllCliCommands(CliProgram cliProgram)
        {
            var cliCommands = new List<CliCommand>();
            GetAllCliCommands(cliProgram.RootCommand, cliCommands);
            return cliCommands;
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
