using System;
using System.IO;

namespace Cake.AzCliParser
{
    public class Logger
    {
        private const string LogFileName = "AzCliParser.log";

        public Logger()
        {
            if (File.Exists(LogFileName))
            {
                File.Delete(LogFileName);
            }
        }

        private void Log(string message)
        {
            File.WriteAllLines(LogFileName, new[] { message });
            Console.WriteLine(message);
        }

        public void Warn(string message)
        {
            Log($"WARN: {DateTime.Now:g} {message}");
        }

        public void Debug(string message)
        {
            Log($"DEBUG: {DateTime.Now:g} {message}");
        }

        public void Error(string message)
        {
            Log($"ERROR: {DateTime.Now:g} {message}");
        }
    }
}
