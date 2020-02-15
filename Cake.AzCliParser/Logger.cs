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
        private readonly FileStream _fileStream;
        private readonly StreamWriter _streamWriter;
        private const string LogFileName = "AzCliParser.log";

        public Logger()
        {
            if (File.Exists(LogFileName))
            {
                File.Delete(LogFileName);
            }

            _fileStream = File.OpenWrite(LogFileName);
            _streamWriter = new StreamWriter(_fileStream);
        }

        private void Log(string message)
        {
            _streamWriter.Write(message + Environment.NewLine);
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
            _streamWriter.Close();
            _fileStream.Close();
            _streamWriter.Dispose();
            _fileStream.Dispose();
        }
    }
}
