using System.IO;
using System.Text.Json;

namespace Cake.AzCliParser
{
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
