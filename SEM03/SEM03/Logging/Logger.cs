using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace SEM03.Logging
{
    public static class Logger
    {
        public static string FileName { get; } = Process.GetCurrentProcess().ProcessName + ".log";

        public static void LogInfo(string logStr, bool newLine = true)
        {
            Log("INFO", logStr, newLine);
        }

        public static void LogWarning(string logStr, bool newLine = true)
        {
            Log("WARNING", logStr, newLine);
        }

        public static void LogError(string logStr, bool newLine = true)
        {
            Log("ERROR", logStr, newLine);
        }

        public static void NewLine(int count = 1)
        {
            if (count == 1)
            {
                File.AppendAllText(FileName, Environment.NewLine);
                return;
            }

            var builder = new StringBuilder(Environment.NewLine.Length * count);
            for (var i = 0; i < count; ++i)
                builder.Append(Environment.NewLine);
            File.AppendAllText(FileName, builder.ToString());
        }

        private static void Log(string logType, string logMessage, bool newLine)
        {
#if DEBUG
            File.AppendAllText(FileName, $@"{DateTime.Now:G} {logType}: {logMessage}" + (newLine ? Environment.NewLine : ""));
#endif
        }
    }
}
