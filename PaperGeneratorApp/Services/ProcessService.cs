using System.Diagnostics;

namespace PaperGeneratorApp.Services
{
    public class ProcessService : IProcessService
    {
        public bool Start(string fileName, string arguments, out string output, out string error)
        {
            int exitCode;
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                }
            };

            process.Start();
            output = process.StandardOutput.ReadToEnd();
            error = process.StandardError.ReadToEnd();
            process.WaitForExit();
            exitCode = process.ExitCode;

            if (!process.HasExited)
            {
                process.Kill(true);
            }

            return exitCode == 0;
        }
    }
}