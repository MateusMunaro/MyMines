using MyMines.Models;

namespace MyMines.Services
{
    public class ServerManager
    {
        private List<IServerInterface> _servers = new List<IServerInterface>();
        private DockerComposeManager writer = new DockerComposeManager();
        public ServerManager()
        {
            
        }

        public ServerManager(List<IServerInterface> servers)
        {
            _servers = servers;
        }

        public void Create(Server server)
        {
            _servers.Add(server);
           
            writer.SaveToFile(server);
        }

        public bool IsValid(Server server)
        {
            bool isValid = false;
            
            foreach(var serverInterface in _servers)
            {
                var s = (Server)serverInterface;

                if(s._name == server._name)
                {
                    isValid = !server._state;
                }
            }

            return isValid;
        }
        
        public void Edit(Server server, Server editedServer)
        {
            if (IsValid(server))
            {
                _servers.Remove(server);
                writer.Delete(server);
                Create(editedServer);
            }
        }

        public void Handle(Server server)
        {
            if (_servers.Contains(server))
            {
                if (server._state)
                {
                    server.Stop();
                    writer.Stop(server);
                }
                else
                {
                    server.Start();
                    writer.Start(server);
                }
            }
        } 
        
        public void Delete(Server server)
        {
            _servers.Remove(server);
            writer.Delete(server);
           

        }

        public List<IServerInterface> GetServers()
        {
            return writer.FindServers();

        }



    }
    
}

