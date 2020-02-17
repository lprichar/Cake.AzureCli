using Cake.AzCli.Core.Models;
using System;

namespace Cake.AzCliParser
{
    public class AzCliParser : IDisposable
    {
        private readonly CommandExecutor _commandExecutor;
        private readonly PageParser _pageParser;
        private readonly AzCliGroupParser _groupParser;
        private readonly AzCliCommandParser _commandParser;
        private readonly ILogger _logger;

        public AzCliParser()
        {
            _logger = new Logger();
            _commandExecutor = new CommandExecutor(_logger);
            _pageParser = new PageParser();
            _groupParser = new AzCliGroupParser(_logger);
            _commandParser = new AzCliCommandParser(_logger);
        }

        public CliProgram ParseRoot()
        {
            _logger.Debug("Starting parse");
            var azHelpOutput = _commandExecutor.ExecuteCommand("az --help");
            var parsedPage = _pageParser.ParseString(azHelpOutput);
            var cliGroup = _groupParser.ParsePage(parsedPage);
            ParseGroup("az", cliGroup);
            _logger.Debug("Parse completed");
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
                if (string.IsNullOrWhiteSpace(commandOutput))
                {
                    _logger.Warn($"Apparently no details are available for {parents} {slimCommand}");
                }
                else
                {
                    var commandPage = _pageParser.ParseString(commandOutput);
                    var fullCommand = _commandParser.ParsePage(commandPage);
                    slimCommand.Merge(fullCommand);
                    slimCommand.Parents = parents;
                }
            }

            foreach (var slimSubgroup in cliGroup.Subgroups)
            {
                var commandOutput = _commandExecutor.ExecuteCommand($"{parents} {slimSubgroup.Name} --help");
                var page = _pageParser.ParseString(commandOutput);
                var fullGroup = _groupParser.ParsePage(page);
                slimSubgroup.Merge(fullGroup);
                slimSubgroup.Parents = parents;
                ParseGroup(parents + " " + slimSubgroup.Name, slimSubgroup);
            }
        }

        public void Dispose()
        {
            _logger.Dispose();
        }
    }
}