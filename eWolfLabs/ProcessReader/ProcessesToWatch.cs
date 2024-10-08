namespace Body
{
    public class ProcessesToWatch
    {        
        public string Name { get; set; }
        public string ProcessName { get; set; }

        private bool _isRunning;
        public bool IsRunning
        {
            set
            {
                if (value && !_isRunning)
                {
                    Console.WriteLine($"Started running {Name}");
                    TimerLogger.LogStart(Name);
                }
                if (!value && _isRunning)
                {
                    Console.WriteLine($"Finished running {Name}");
                    TimerLogger.LogEnd(Name);
                }
                _isRunning = value;
            }
        }
    }
}