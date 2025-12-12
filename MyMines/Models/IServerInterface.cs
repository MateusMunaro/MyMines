using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMines.Models
{
    public interface IServerInterface
    {
        string Name { get; set; }
        string Image { get; set; }
        Dictionary<string, string> Environment { get; set; }
        int Port { get; set; }
        string Volumes { get; set; }
        bool IsRunning { get; set; }
        string IpAddress { get; set; }
        
        void Start();
        void Stop();
    }
}
