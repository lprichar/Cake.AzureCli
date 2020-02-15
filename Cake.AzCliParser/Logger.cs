using System;

namespace Cake.AzCliParser
{
    public class Logger
    {
        public void Warn(string message)
        {
            Console.WriteLine("WARN: " + message);
        }

        public void Debug(string message)
        {
            Console.WriteLine("DEBUG: " + message);
        }
    }
}
