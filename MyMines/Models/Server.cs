using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMines.Models
{
    internal class Server : IServerInterface
    {
        public string? Name { get; set; }
        public Dictionary<string, string>? Environment { get; set; }
        public short Ports { get; set; }
        public string? Volumes { get; set; }
        public bool State { get; set; }
        public string? IpAddress { get; set; }

        public Server() { }

        public Server(string name, Dictionary<string, string> environment, short ports, string volumes, bool state)
        {
            Name = name;
            Environment = environment;
            Ports = ports;
            Volumes = volumes;
            State = state;
        }

        public void Start()
        {
            // Implementar lógica para iniciar o servidor
            State = true;
        }

        public void Stop()
        {
            // Implementar lógica para parar o servidor
            State = false;
        }
    }
}
