using System.Diagnostics;
using System.Linq;

namespace Cake.AzCliParser
{
    public class CommandExecutor
    {
        private readonly ILogger _logger;

        public CommandExecutor(ILogger logger)
        {
            _logger = logger;
        }

        public string ExecuteCommand(string command)
        {
            using var process = new Process
            {
                StartInfo =
                {
                    FileName = @"C:\Windows\System32\cmd.exe",
                    Verb = "runas",
                    Arguments = "/c " + command,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                }
            };

            _logger.Debug(command);
            process.Start();

            process.WaitForExit(1);
            var helpOutput = process.StandardOutput.ReadToEnd();
            var standardError = process.StandardError.ReadToEnd();
            var anyError = !string.IsNullOrWhiteSpace(standardError);
            if (anyError)
            {
                var isFalsePositiveError = FalsePositiveErrors.Contains(standardError);
                if (!isFalsePositiveError)
                {
                    _logger.Error(standardError);
                }
            }

            return helpOutput;
        }

        private static readonly string[] FalsePositiveErrors = {
            "Please let us know how we are doing: https://aka.ms/azureclihats\r\nand let us know if you're interested in trying out our newest features: https://aka.ms/CLIUXstudy\r\n",
            "Please let us know how we are doing: https://aka.ms/azureclihats\r\n",
        };

    }
}
