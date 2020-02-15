using System.Diagnostics;

namespace Cake.AzCliParser
{
    public class CommandExecutor
    {
        public string ExecuteCommand(string command)
        {
            var process = new Process
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

            process.Start();

            process.WaitForExit(500);
            var helpOutput = process.StandardOutput.ReadToEnd();
            return helpOutput;
        }

    }
}
