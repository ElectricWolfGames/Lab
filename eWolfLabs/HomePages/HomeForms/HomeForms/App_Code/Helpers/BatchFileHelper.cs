using System;
using System.Diagnostics;
using System.Text;

namespace HomeForms.Helpers
{
    public static class BatchFileHelper
    {
        public static int ExecuteCommand(string command)
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            // Warning: This approach can lead to deadlocks, see Edit #2
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            exitCode = process.ExitCode;

            Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
            Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
            Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
            process.Close();

            return exitCode;
        }

        public static int RunUnitTestFor(string dllToTest)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"c:\Apps\NUnit.Console-3.7.0\nunit3-console.exe {dllToTest}");
            return ExecuteCommand(sb.ToString());
        }
    }
}
