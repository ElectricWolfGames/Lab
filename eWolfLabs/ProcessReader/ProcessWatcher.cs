using System.Diagnostics;

namespace Body
{
    public class ProcessWatcher
    {
        private List<ProcessesToWatch> _processesToWatch = new List<ProcessesToWatch>();

        public ProcessWatcher()
        {
            ProcessesToWatch processesToWatch = new ProcessesToWatch()
            {
                Name = "Labs",
                ProcessName = "Lab_UD",
            };
            _processesToWatch.Add(processesToWatch);

            processesToWatch = new ProcessesToWatch()
            {
                Name = "GCR",
                ProcessName = "GCR_UD",
            };
            _processesToWatch.Add(processesToWatch);

            processesToWatch = new ProcessesToWatch()
            {
                Name = "2D Game",
                ProcessName = "2DLabs_UD",
            };
            _processesToWatch.Add(processesToWatch);

            processesToWatch = new ProcessesToWatch()
            {
                Name = "Space Salvager",
                ProcessName = "SpaceSalvager_UD",
            };
            _processesToWatch.Add(processesToWatch);

            processesToWatch = new ProcessesToWatch()
            {
                Name = "Carry On Training",
                ProcessName = "CarryOnTraining_UD",
            };
            _processesToWatch.Add(processesToWatch);

            processesToWatch = new ProcessesToWatch()
            {
                Name = "Railways",
                ProcessName = "Railways_UD",
            };
            _processesToWatch.Add(processesToWatch);

            processesToWatch = new ProcessesToWatch()
            {
                Name = "RailwayTrackBuilder",
                ProcessName = "RailwayTrackBuilder_UD",
            };
            _processesToWatch.Add(processesToWatch);


        }

        public void Check()
        {
            var process = Process.GetProcesses();
            // foreach (var p in process)
            // {
            //     Console.WriteLine(p.MainWindowTitle);
            // }
            foreach (var p in _processesToWatch)
            {
                string name = p.ProcessName;

                if (process.Any(x => x.MainWindowTitle.Contains(p.ProcessName)))
                {
                    p.IsRunning = true;
                }
                else
                {
                    p.IsRunning = false;
                }
            }
        }
    }
}