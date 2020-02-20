using Cake.Common.Diagnostics;
using Cake.Core;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Cake.AzureCli
{
    public class CommandExecutor
    {
        private readonly ICakeContext _context;

        public CommandExecutor(ICakeContext context)
        {
            _context = context;
        }

        public dynamic ExecuteCommand(string command)
        {
            var startInfo = GetCrossPlatStartInfo(command);
            using (var process = new Process { StartInfo = startInfo })
            {
                _context.Debug("Executing: " + command);
                process.Start();

                process.WaitForExit(10);
                var standardOut = process.StandardOutput.ReadToEnd();
                var standardError = process.StandardError.ReadToEnd();
                if (!string.IsNullOrWhiteSpace(standardError))
                {
                    _context.Error("ERROR EXECUTING: " + standardError);
                }
                else
                {
                    _context.Debug(standardOut);
                }

                return ToDynamicJson(standardOut);
            }
        }

        private static ProcessStartInfo GetCrossPlatStartInfo(string command)
        {
            var cmd = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "cmd.exe" : "bash";
            var cmdArg = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "/c " : "";
            return new ProcessStartInfo
            {
                FileName = cmd,
                Arguments = cmdArg + command + "",
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
        }

        private dynamic ToDynamicJson(string jsonString)
        {
            var trimStart = jsonString.TrimStart();
            if (trimStart.StartsWith("["))
            {
                return JArray.Parse(jsonString);
            }
            if (trimStart.StartsWith("{"))
            {
                return JObject.Parse(jsonString);
            }
            return jsonString;
        }
    }
}
