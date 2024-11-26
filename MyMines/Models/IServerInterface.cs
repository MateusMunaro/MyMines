using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMines.Models
{
    public interface IServerInterface
    {
        string _name { get; set; }
        string _image { get; set; }
        Dictionary<string, string> _environment { get; set; }
        short _ports { get; set; }
        string _volumes { get; set; }
        bool _state { get; set; }
        string _ipAddress { get; set; }
        private const string IMAGE = "itzg/minecraft-server";
        public void Start();
        public void Stop();
        

    }
}
