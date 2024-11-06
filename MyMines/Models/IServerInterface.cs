using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMines.Models
{
    internal class IServerInterface
    {
        string? Name { get; set; }
        Dictionary<string, string>? Environment { get; set; }
        short Ports { get; set; }
        string? Volumes { get; set; }
        bool State { get; set; }
        string? IpAddress { get; set; }

        //void Start();
        //void Stop();
    }
}
