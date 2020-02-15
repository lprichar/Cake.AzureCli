using System.Diagnostics;

namespace Cake.AzCliParser
{
    public class CommandExecutor
    {
        private Logger _logger;

        public CommandExecutor()
        {
            _logger = new Logger();
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
                    RedirectStandardOutput = true
                }
            };

            _logger.Debug(command);
            process.Start();

            process.WaitForExit(100);
            var helpOutput = process.StandardOutput.ReadToEnd();
            return helpOutput;
        }

    }
}
