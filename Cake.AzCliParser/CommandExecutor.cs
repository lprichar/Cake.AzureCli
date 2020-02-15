using System.Diagnostics;

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

            process.WaitForExit(50);
            var helpOutput = process.StandardOutput.ReadToEnd();
            var standardError = process.StandardError.ReadToEnd();
            if (!string.IsNullOrWhiteSpace(standardError))
            {
                _logger.Error(standardError);
            }

            return helpOutput;
        }

    }
}
