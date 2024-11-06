using MyMines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMines.Services
{
    internal class ServerManager
    {
        private readonly List<Server> _servers;

        public ServerManager()
        {
            _servers = new List<Server>();
        }

        public void CreateServer(string name, string ipAddress, Dictionary<string, string> environment, short ports, string volumes)
        {
            Server server = new Server(name, environment, ports, volumes, false)
            {
                IpAddress = ipAddress
            };
        }

        public bool StartServer(string name)
        {
            Server server = _servers.Find(s => s.Name == name);
            if (server != null && !server.State) 
            {
                server.Start();
                return true;
            
            }
            return false;
        }

        public bool StopServer(string name)
        {
            Server server = _servers.Find(s => s.Name == name);
            if (server != null && !server.State)
            {
                server.Stop();
                return true;

            }
            return false;

        }

        public List<Server> GetAllServers()
        {
            return _servers;
        }

        public Server GetServerByName(string name)
        {
            return _servers.Find(s => s.Name == name);
        }
    }
}
