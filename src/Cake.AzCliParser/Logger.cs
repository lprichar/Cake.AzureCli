using System;
using System.IO;

namespace Cake.AzCliParser
{
    public interface ILogger : IDisposable
    {
        void Warn(string message);
        void Debug(string message);
        void Error(string message);
    }

    public class Logger : ILogger
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
            File.AppendAllText(LogFileName, message + Environment.NewLine);
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

        public void Dispose()
        {
        }
    }
}
