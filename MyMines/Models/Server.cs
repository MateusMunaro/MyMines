using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMines.Models
{
    public class Server : IServerInterface
    {
        public string _name { get; set; }
        public string _image { get; set; }
        public Dictionary<string, string> _environment { get; set; }
        public short _ports { get; set; }
        public string _volumes { get; set; }
        public bool _state { get; set; }
        public string _ipAddress { get; set; }
        private const string IMAGE = "itzg/minecraft-server";


        public Server(string name)
        {
            _name = name;
        }

        public Server()
        {
           
        }

        public Server(string name, Dictionary<string, string> environment, short ports, string volumes, bool state)
        {
            _name = name;
            _environment = environment;
            _ports = ports;
            _volumes = volumes;
            _state = state;
        }
        

        public void Start()
        {
            _state = true;
        }
        
        public void Stop()
        {
            _state = false;
        }
    }
}
