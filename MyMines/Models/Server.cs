using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMines.Models
{
    public class Server : IServerInterface
    {
        private const string IMAGE = "itzg/minecraft-server";

        public string Name { get; set; }
        public string Image { get; set; }
        public Dictionary<string, string> Environment { get; set; }
        public int Port { get; set; }
        public string Volumes { get; set; }
        public bool IsRunning { get; set; }
        public string IpAddress { get; set; }

        public Server()
        {
            Image = IMAGE;
            Environment = new Dictionary<string, string>();
            Port = 25565;
            IsRunning = false;
        }

        public Server(string name) : this()
        {
            Name = name;
        }

        public Server(string name, Dictionary<string, string> environment, int port, string volumes, bool state) : this()
        {
            Name = name;
            Environment = environment ?? new Dictionary<string, string>();
            Port = port;
            Volumes = volumes;
            IsRunning = state;
        }

        public void Start()
        {
            IsRunning = true;
        }

        public void Stop()
        {
            IsRunning = false;
        }

        public override string ToString() => Name;

        public override bool Equals(object? obj)
        {
            if (obj is Server other)
            {
                return string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode() => Name?.GetHashCode() ?? 0;
    }
}
