namespace Body
{
    public static class TimerLogger
    {
        private static string LogPathRoot = "E:\\Projects\\Timers\\";
        internal static void LogStart(string name)
        {
            var file = GetFile(name);
            file += $"\nStart|{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")}";
            SaveFile(name, file);
        }

        private static string GetFile(string name)
        {
            string fullPath = $"{LogPathRoot}{name}";
            if (File.Exists(fullPath))
            {
                return File.ReadAllText(fullPath);
            }
            return "";
        }
        private static void SaveFile(string name, string file)
        {
            string fullPath = $"{LogPathRoot}{name}";
            File.WriteAllText(fullPath, file);
        }

        private static string GetCurrentDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }

        internal static void LogEnd(string name)
        {
            var file = GetFile(name);
            file += $"\nEnd|{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")}";
            SaveFile(name, file);
        }
    }
}