using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace Cake.AzCliParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string anyCommand = "az --help";

            var process = new Process();
            process.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            process.StartInfo.Verb = "runas";
            process.StartInfo.Arguments = "/c " + anyCommand;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.StartInfo.RedirectStandardOutput = true;

            process.Start();

            process.WaitForExit(500);
            var helpOutput = process.StandardOutput.ReadToEnd();
            var pageParser = new PageParser();
            var parsedPage = pageParser.ParsePage(helpOutput);
            var azCliParserService = new AzCliParserService();
            CliGroup cliGroup = azCliParserService.ParseCliGroup(parsedPage);
            var cliProgram = new CliProgram
            {
                RootCommand = cliGroup
            };
            var cliProgramSerialized = JsonSerializer.Serialize(cliProgram);
            File.WriteAllText("out.json", cliProgramSerialized);
        }
    }
}
