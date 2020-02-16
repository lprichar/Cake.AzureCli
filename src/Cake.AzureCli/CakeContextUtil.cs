using Cake.Core;
using LogLevel = Cake.Core.Diagnostics.LogLevel;
using Verbosity = Cake.Core.Diagnostics.Verbosity;

namespace Cake.AzureCli
{
    public static class CakeContextUtil
    {
        private static void Write(this ICakeContext context, LogLevel logLevel, string message)
        {
            var messageSafe = message.Replace("{", "{{")
                .Replace("}", "}}");
            context.Log.Write(Verbosity.Normal, logLevel, messageSafe);
        }

        public static void Debug(this ICakeContext context, string message)
        {
            context.Write(LogLevel.Debug, message);
        }

        public static void Warn(this ICakeContext context, string message)
        {
            context.Write(LogLevel.Warning, message);
        }

        public static void Error(this ICakeContext context, string message)
        {
            context.Write(LogLevel.Error, message);
        }
    }
}