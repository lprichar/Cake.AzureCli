using Cake.Common.Diagnostics;
using Cake.Core;
using Cake.Core.IO;
using Newtonsoft.Json.Linq;
using System;
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

        public dynamic ExecuteCommand(ProcessArgumentBuilder processArgumentBuilder)
        {
            var startInfo = GetCrossPlatStartInfo(processArgumentBuilder.Render());
            using (var process = new Process { StartInfo = startInfo })
            {
                _context.Debug("Executing: " + processArgumentBuilder.RenderSafe());
                process.Start();

                var standardOutTask = process.StandardOutput.ReadToEndAsync();
                var standardErrorTask = process.StandardError.ReadToEndAsync();
                process.WaitForExit();
                var standardOut = standardOutTask.GetAwaiter().GetResult();
                var standardError = standardErrorTask.GetAwaiter().GetResult();
                if (!string.IsNullOrWhiteSpace(standardError))
                {
                    _context.Error("ERROR EXECUTING: " + standardError);
                }
                else
                {
                    _context.Debug(standardOut);
                }

                if (process.ExitCode != 0)
                {
                    throw new InvalidOperationException(
                        $"Azure CLI command failed with exit code {process.ExitCode}. Command: {processArgumentBuilder.RenderSafe()}{Environment.NewLine}{standardError}");
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
