using System.IO;
using System.Text.Json;

namespace Cake.AzCliParser
{
    public class AzCliParser
    {
        private CommandExecutor _commandExecutor;
        private PageParser _pageParser;
        private AzCliGroupParser _groupParser;
        private AzCliCommandParser _commandParser;

        public AzCliParser()
        {
            _commandExecutor = new CommandExecutor();
            _pageParser = new PageParser();
            _groupParser = new AzCliGroupParser();
            _commandParser = new AzCliCommandParser();
        }

        public CliProgram ParseRoot()
        {
            var azHelpOutput = _commandExecutor.ExecuteCommand("az --help");
            var parsedPage = _pageParser.ParsePage(azHelpOutput);
            var cliGroup = _groupParser.ParsePage(parsedPage);
            ParseGroup("az", cliGroup);
            return new CliProgram
            {
                RootCommand = cliGroup,
            };
        }

        private void ParseGroup(string parents, CliGroup cliGroup)
        {
            foreach (var slimCommand in cliGroup.Commands)
            {
                var commandOutput = _commandExecutor.ExecuteCommand($"{parents} {slimCommand.Name} --help");
                var commandPage = _pageParser.ParsePage(commandOutput);
                var fullCommand = _commandParser.ParsePage(commandPage);
                slimCommand.Merge(fullCommand);
                slimCommand.Parents = parents;
            }

            foreach (var slimSubgroup in cliGroup.Subgroups)
            {
                var commandOutput = _commandExecutor.ExecuteCommand($"{parents} {slimSubgroup.Name} --help");
                var page = _pageParser.ParsePage(commandOutput);
                var fullGroup = _groupParser.ParsePage(page);
                slimSubgroup.Merge(fullGroup);
                slimSubgroup.Parents = parents;
                ParseGroup(parents + " " + slimSubgroup.Name, slimSubgroup);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var azCliParser = new AzCliParser();
            var cliProgram = azCliParser.ParseRoot();
            WriteOutCliProgram(cliProgram);
        }

        private static void WriteOutCliProgram(CliProgram cliProgram)
        {
            var cliProgramSerialized = JsonSerializer.Serialize(cliProgram, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
            File.WriteAllText("../../../out.json", cliProgramSerialized);
        }
    }
}
