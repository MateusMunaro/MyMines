using System.Diagnostics;
using System.Text;

namespace MyMines.Services
{
    public class DockerCommandExecutor
    {
        public async Task<(bool Success, string Output, string Error)> ExecuteCommandAsync(string workingDirectory, string command)
        {
            if (string.IsNullOrWhiteSpace(workingDirectory))
                throw new ArgumentException("Working directory cannot be null or empty", nameof(workingDirectory));

            if (string.IsNullOrWhiteSpace(command))
                throw new ArgumentException("Command cannot be null or empty", nameof(command));

            if (!Directory.Exists(workingDirectory))
                throw new DirectoryNotFoundException($"Directory not found: {workingDirectory}");

            if (command.StartsWith("docker"))
            {
                var dockerCheck = await IsDockerRunningAsync();
                if (!dockerCheck)
                {
                    return (false, string.Empty, "Docker is not running. Please start Docker Desktop and try again.");
                }
            }

            var outputBuilder = new StringBuilder();
            var errorBuilder = new StringBuilder();

            var processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C cd /d \"{workingDirectory}\" && {command}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = workingDirectory
            };

            try
            {
                using (var process = new Process { StartInfo = processStartInfo })
                {
                    process.OutputDataReceived += (sender, args) =>
                    {
                        if (!string.IsNullOrEmpty(args.Data))
                            outputBuilder.AppendLine(args.Data);
                    };

                    process.ErrorDataReceived += (sender, args) =>
                    {
                        if (!string.IsNullOrEmpty(args.Data))
                            errorBuilder.AppendLine(args.Data);
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    await process.WaitForExitAsync();

                    return (process.ExitCode == 0, outputBuilder.ToString(), errorBuilder.ToString());
                }
            }
            catch (Exception ex)
            {
                return (false, string.Empty, $"Exception: {ex.Message}");
            }
        }

        public async Task<bool> IsDockerRunningAsync()
        {
            try
            {
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "docker",
                    Arguments = "info",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();
                    await process.WaitForExitAsync();
                    return process.ExitCode == 0;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> IsDockerComposeInstalledAsync()
        {
            try
            {
                var result = await ExecuteCommandAsync(Environment.CurrentDirectory, "docker-compose --version");
                return result.Success;
            }
            catch
            {
                return false;
            }
        }
    }
}
