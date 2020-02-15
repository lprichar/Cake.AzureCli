using System.IO;
using System.Text.Json;

namespace Cake.AzCliParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var azCliParser = new AzCliParser();
            try
            {
                var cliProgram = azCliParser.ParseRoot();
                WriteOutCliProgram(cliProgram);
            }
            finally
            {
                azCliParser.Dispose();
            }
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
