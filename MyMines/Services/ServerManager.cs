using MyMines.Models;

namespace MyMines.Services
{
    public class ServerManager
    {
        private readonly List<IServerInterface> _servers;
        private readonly DockerComposeManager _dockerComposeManager;

        public ServerManager()
        {
            _servers = new List<IServerInterface>();
            _dockerComposeManager = new DockerComposeManager();
        }

        public ServerManager(List<IServerInterface> servers) : this()
        {
            _servers = servers ?? new List<IServerInterface>();
        }

        public async Task<(bool Success, string Message)> CreateAsync(Server server, ServerConfiguration? configuration = null)
        {
            if (server == null)
                return (false, "Server cannot be null");

            if (string.IsNullOrWhiteSpace(server.Name))
                return (false, "Server name cannot be empty");

            if (ServerExists(server.Name))
                return (false, $"Server '{server.Name}' already exists");

            try
            {
                await _dockerComposeManager.SaveToFileAsync(server, configuration);
                _servers.Add(server);
                return (true, "Server created successfully");
            }
            catch (Exception ex)
            {
                return (false, $"Failed to create server: {ex.Message}");
            }
        }

        public bool IsValid(Server server)
        {
            if (server == null)
                return false;

            var existingServer = _servers
                .OfType<Server>()
                .FirstOrDefault(s => string.Equals(s.Name, server.Name, StringComparison.OrdinalIgnoreCase));

            return existingServer != null && !existingServer.IsRunning;
        }

        public async Task<(bool Success, string Message)> EditAsync(Server originalServer, Server editedServer)
        {
            if (originalServer == null)
                return (false, "Original server cannot be null");

            if (editedServer == null)
                return (false, "Edited server cannot be null");

            if (!IsValid(originalServer))
                return (false, "Cannot edit a running server");

            try
            {
                await DeleteAsync(originalServer);
                return await CreateAsync(editedServer);
            }
            catch (Exception ex)
            {
                return (false, $"Failed to edit server: {ex.Message}");
            }
        }

        public async Task<(bool Success, string Message)> HandleAsync(Server server)
        {
            if (server == null)
                return (false, "Server cannot be null");

            if (!_servers.Contains(server))
                return (false, "Server not found");

            try
            {
                if (server.IsRunning)
                {
                    var result = await _dockerComposeManager.StopAsync(server);
                    return result;
                }
                else
                {
                    var result = await _dockerComposeManager.StartAsync(server);
                    return result;
                }
            }
            catch (Exception ex)
            {
                return (false, $"Failed to handle server: {ex.Message}");
            }
        }

        public async Task<(bool Success, string Message)> DeleteAsync(Server server)
        {
            if (server == null)
                return (false, "Server cannot be null");

            try
            {
                if (server.IsRunning)
                {
                    await _dockerComposeManager.StopAsync(server);
                }

                await _dockerComposeManager.DeleteAsync(server);
                _servers.Remove(server);
                return (true, "Server deleted successfully");
            }
            catch (Exception ex)
            {
                return (false, $"Failed to delete server: {ex.Message}");
            }
        }

        public async Task<List<IServerInterface>> GetServersAsync()
        {
            try
            {
                return await _dockerComposeManager.FindServersAsync();
            }
            catch (Exception)
            {
                return new List<IServerInterface>();
            }
        }

        public async Task<bool> RefreshServerStatusAsync(Server server)
        {
            if (server == null)
                return false;

            try
            {
                bool isRunning = await _dockerComposeManager.IsServerRunningAsync(server);
                server.IsRunning = isRunning;
                return isRunning;
            }
            catch
            {
                return false;
            }
        }

        private bool ServerExists(string serverName)
        {
            return _servers.Any(s => string.Equals(s.Name, serverName, StringComparison.OrdinalIgnoreCase));
        }

        public IReadOnlyList<IServerInterface> GetAllServers()
        {
            return _servers.AsReadOnly();
        }
    }
}

