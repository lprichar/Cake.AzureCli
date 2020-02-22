using Cake.AzCli.Core.Models;
using System.IO;
using System.Text.Json;

namespace Cake.AzCliParser
{
    class Program
    {
        private const string OutputJsonFile = "../../../../Cake.AzureCli/AzCliHelpOutput.json";
        private const string OutputJsonMinifiedFile = "../../../../Cake.AzureCli/AzCliHelpOutput.min.json";

        static void Main(string[] args)
        {
            var azCliParser = new AzCliParser();
            try
            {
                var cliProgram = azCliParser.ParseRoot();
                WriteOutCliProgram(cliProgram, OutputJsonFile, true);
                WriteOutCliProgram(cliProgram, OutputJsonMinifiedFile, false);
            }
            finally
            {
                azCliParser.Dispose();
            }
        }

        private static void WriteOutCliProgram(CliProgram cliProgram, string file, bool indented)
        {
            var cliProgramSerialized = JsonSerializer.Serialize(cliProgram, new JsonSerializerOptions
            {
                WriteIndented = indented,
            });
            File.WriteAllText(file, cliProgramSerialized);
        }
    }
}
