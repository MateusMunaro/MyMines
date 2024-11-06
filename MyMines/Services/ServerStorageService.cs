using MyMines.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MyMines.Services
{
    internal class ServerStorageService
    {
        private readonly string _storageDirectory;

        public ServerStorageService()
        {
            _storageDirectory = Path.Combine(Directory.GetCurrentDirectory(), "ServersData");

            // Cria o diretório se ele não existir
            if (!Directory.Exists(_storageDirectory))
                Directory.CreateDirectory(_storageDirectory);
        }

        public void SaveServer(Server server)
        {
            string filePath = Path.Combine(_storageDirectory, $"{server.Name}.json");
            string json = JsonSerializer.Serialize(server, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public Server? LoadServer(string name)
        {
            string filePath = Path.Combine(_storageDirectory, $"{name}.json");
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<Server>(json);
            }
            return null;
        }

        //public List<Server> LoadAllServers()
        //{
        //    List<Server> servers = new List<Server>();

        //    foreach (string filePath in Directory.GetFiles(_storageDirectory, "*.json"))
        //    {
        //        string json = File.ReadAllText(filePath);
        //        Server? server = JsonSerializer.Deserialize<Server>(json);
        //        if (server != null)
        //            servers.Add(server);
        //    }
        //    return servers;
        //}
    }
}
