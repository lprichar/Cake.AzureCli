using System.IO;
using System.Text.Json;

namespace Cake.AzCliParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandExecutor = new CommandExecutor();
            var pageParser = new PageParser();
            var groupParser = new AzCliGroupParser();
            var commandParser = new AzCliCommandParser();

            var azHelpOutput = commandExecutor.ExecuteCommand("az --help");
            var parsedPage = pageParser.ParsePage(azHelpOutput);
            CliGroup cliGroup = groupParser.ParseCliGroup(parsedPage);
            foreach (var command in cliGroup.Commands)
            {
                var commandOutput = commandExecutor.ExecuteCommand(command.Name + " --help");
                var commandPage = pageParser.ParsePage(commandOutput);
                var cliCommand = commandParser.ParseCliCommand(commandPage);
                command.Merge(cliCommand);
            }
            var cliProgram = new CliProgram
            {
                RootCommand = cliGroup,
            };
            WriteOutCliProgram(cliProgram);
        }

        private static void WriteOutCliProgram(CliProgram cliProgram)
        {
            var cliProgramSerialized = JsonSerializer.Serialize(cliProgram);
            File.WriteAllText("out.json", cliProgramSerialized);
        }
    }
}
