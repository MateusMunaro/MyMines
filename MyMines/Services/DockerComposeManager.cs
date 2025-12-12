using MyMines.Models;
using System.Text;

namespace MyMines.Services
{
    public class DockerComposeManager
    {
        private const string SERVICES_TEMPLATE = @"#DEVELOPED BY MYMINES
services:

  mc:
    image: itzg/minecraft-server
    volumes:
      - ./data:/data
      - ./mods:/mods:ro
    ports:
      - ""{port}:{port}""
    environment:
      EULA: ""TRUE""
      DEBUG: ""true""
      DIFFICULTY: ""{difficulty}""
      SERVER_NAME: ""{name}""
      ALLOW_FLIGHT: ""true""
      MAX_MEMORY: ""3G""
      ONLINE_MODE: ""false""
      OVERRIDE_SERVER_PROPERTIES: ""true""
      ENABLE_WHITELIST: ""FALSE""
      ENFORCE_WHITELIST: ""FALSE""
      LOG_TIMESTAMP: ""true""
      SNOOPER_ENABLED: ""false""

    tty: true
    stdin_open: true
    restart: unless-stopped
volumes:
  data: {}
";

        private readonly DockerCommandExecutor _commandExecutor;
        private readonly string _serversBasePath;

        public DockerComposeManager() : this(Environment.CurrentDirectory)
        {
        }

        public DockerComposeManager(string basePath)
        {
            _serversBasePath = basePath ?? throw new ArgumentNullException(nameof(basePath));
            _commandExecutor = new DockerCommandExecutor();

            if (!Directory.Exists(_serversBasePath))
            {
                Directory.CreateDirectory(_serversBasePath);
            }
        }

        public async Task AddServerAsync(Server server, ServerConfiguration? configuration = null)
        {
            if (server == null)
                throw new ArgumentNullException(nameof(server));

            if (string.IsNullOrWhiteSpace(server.Name))
                throw new ArgumentException("Server name cannot be null or empty", nameof(server));

            await SaveToFileAsync(server, configuration);
        }

        public async Task SaveToFileAsync(Server server, ServerConfiguration? configuration = null)
        {
            if (server == null)
                throw new ArgumentNullException(nameof(server));

            configuration ??= new ServerConfiguration();

            string serverPath = GetServerPath(server.Name);
            string dockerComposePath = Path.Combine(serverPath, "docker-compose.yml");

            if (!Directory.Exists(serverPath))
            {
                Directory.CreateDirectory(serverPath);
            }

            string fileContent = SERVICES_TEMPLATE
                .Replace("{version}", configuration.Version)
                .Replace("{difficulty}", configuration.Difficulty)
                .Replace("{name}", server.Name)
                .Replace("{port}", server.Port.ToString());

            await File.WriteAllTextAsync(dockerComposePath, fileContent, Encoding.UTF8);
        }

        public async Task<List<IServerInterface>> FindServersAsync()
        {
            var servers = new List<IServerInterface>();

            if (!Directory.Exists(_serversBasePath))
                return servers;

            var directories = Directory.GetDirectories(_serversBasePath);

            foreach (var directory in directories)
            {
                var dockerComposePath = Path.Combine(directory, "docker-compose.yml");
                if (File.Exists(dockerComposePath))
                {
                    var serverName = Path.GetFileName(directory);
                    servers.Add(new Server(serverName));
                }
            }

            return servers;
        }

        public async Task DeleteAsync(Server server)
        {
            if (server == null)
                throw new ArgumentNullException(nameof(server));

            string serverPath = GetServerPath(server.Name);

            if (Directory.Exists(serverPath))
            {
                await StopAsync(server);
                
                await Task.Run(() =>
                {
                    try
                    {
                        Directory.Delete(serverPath, true);
                    }
                    catch (IOException)
                    {
                        System.Threading.Thread.Sleep(100);
                        Directory.Delete(serverPath, true);
                    }
                });
            }
        }

        public async Task<(bool Success, string Message)> StartAsync(Server server)
        {
            if (server == null)
                throw new ArgumentNullException(nameof(server));

            string serverPath = GetServerPath(server.Name);

            if (!Directory.Exists(serverPath))
                return (false, $"Server directory not found: {serverPath}");

            var dockerComposePath = Path.Combine(serverPath, "docker-compose.yml");
            if (!File.Exists(dockerComposePath))
                return (false, $"docker-compose.yml not found in: {serverPath}");

            var result = await _commandExecutor.ExecuteCommandAsync(serverPath, "docker-compose up -d");

            if (result.Success)
            {
                server.Start();
                return (true, "Server started successfully");
            }

            string errorMessage = result.Error;
            if (errorMessage.Contains("unable to get image"))
            {
                errorMessage = "Failed to start server. Please ensure:\n" +
                              "1. Docker Desktop is running\n" +
                              "2. You have internet connection to download the image\n" +
                              "3. Docker is configured correctly\n\n" +
                              $"Original error: {result.Error}";
            }

            return (false, errorMessage);
        }

        public async Task<(bool Success, string Message)> StopAsync(Server server)
        {
            if (server == null)
                throw new ArgumentNullException(nameof(server));

            string serverPath = GetServerPath(server.Name);

            if (!Directory.Exists(serverPath))
                return (false, $"Server directory not found: {serverPath}");

            var result = await _commandExecutor.ExecuteCommandAsync(serverPath, "docker-compose down");

            if (result.Success)
            {
                server.Stop();
                return (true, "Server stopped successfully");
            }

            return (false, $"Failed to stop server: {result.Error}");
        }

        public async Task<bool> IsServerRunningAsync(Server server)
        {
            if (server == null)
                throw new ArgumentNullException(nameof(server));

            string serverPath = GetServerPath(server.Name);

            if (!Directory.Exists(serverPath))
                return false;

            var result = await _commandExecutor.ExecuteCommandAsync(serverPath, "docker-compose ps -q");
            return result.Success && !string.IsNullOrWhiteSpace(result.Output);
        }

        public async Task<string> GetServerIPAsync(Server server)
        {
            if (server == null)
                throw new ArgumentNullException(nameof(server));

            string serverPath = GetServerPath(server.Name);

            if (!Directory.Exists(serverPath))
                return "127.0.0.1";

            try
            {
                var result = await _commandExecutor.ExecuteCommandAsync(
                    serverPath, 
                    "docker inspect -f \"{{range.NetworkSettings.Networks}}{{.IPAddress}}{{end}}\" $(docker-compose ps -q)"
                );

                if (result.Success && !string.IsNullOrWhiteSpace(result.Output))
                {
                    return result.Output.Trim();
                }
            }
            catch
            {
            }

            return "127.0.0.1";
        }

        private string GetServerPath(string serverName)
        {
            if (string.IsNullOrWhiteSpace(serverName))
                throw new ArgumentException("Server name cannot be null or empty", nameof(serverName));

            return Path.Combine(_serversBasePath, serverName);
        }
    }
}

