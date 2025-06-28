using System;
using System.Collections.Generic;

namespace CybersecuritychatbotGUI
{
    public static class ActivityLog
    {
        private static readonly List<string> log = new List<string>();
        private const int MaxLogSize = 100;

        public static void Add(string message)
        {
            string entry = $"{DateTime.Now:HH:mm:ss} - {message}";
            log.Add(entry);

            if (log.Count > MaxLogSize)
                log.RemoveAt(0);
        }

        public static List<string> GetRecent(int count = 10)
        {
            int skip = Math.Max(log.Count - count, 0);
            return log.GetRange(skip, log.Count - skip);
        }
    }
}