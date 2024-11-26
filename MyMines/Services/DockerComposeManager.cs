using MyMines.Models;
using System.Diagnostics;
namespace MyMines.Services
{

    public class DockerComposeManager
    {
        private string _services_template = @"
#DEVELOPED BY MYMINES
version: ""3""
services:

  mc:
    image: itzg/minecraft-server
    volumes:
      - ./data:/data
      - ./mods:/mods:ro
    ports:
      - ""25565:25565""
    environment:
      EULA: ""TRUE""
      DEBUG: ""true""
      VERSION: ""{version}""
      DIFFICULTY: ""{difficulty}""
      SERVER_NAME: ""{name}""
      ALLOW_FLIGHT: ""true""
      MAX_MEMORY: ""3G""
      ONLINE_MODE: ""false""
      OVERRIDE_SERVER_PROPERTIES: ""true""
      ENABLE_WHITELIST: ""FALSE""
      ENFORE_WHITELIST: ""FALSE""
      LOG_TIMESTAMP: ""true""
      SNOOPER_ENABLED: ""false""

    tty: true
    stdin_open: true
    restart: unless-stopped
volumes:
  data: {}


 

        "; 
        
 

        public DockerComposeManager() { }

        public void AddServer(Server server)
        {  
            SaveToFile(server);
        }
        
        public void SaveToFile(Server server)
        {
            string path = $"./{server._name}/docker-compose.yml";
            if (!Directory.Exists($"./{server._name}"))
            {
                Directory.CreateDirectory($"./{server._name}");
            }

            string fileContent = _services_template
                .Replace("{version}", "1.20.2")
                .Replace("{difficulty}", "HARD")
                .Replace("{name}", server._name);
            

            File.WriteAllText(path, fileContent);
        }

        public List<IServerInterface> FindServers(){
            List<IServerInterface> servers = new List<IServerInterface>();

            foreach(var folder in Directory.GetDirectories("./"))
            {
                if(Directory.Exists($"{folder}/docker-compose.yml"))
                {
                    servers.Add(new Server(folder));
                }
            }

            return servers;
            
        }

        public void Delete(Server server)
        {
            string path = $"./{server._name}";
            if (!Directory.Exists($"./{server._name}"))
            {
                foreach (var file in Directory.GetFiles(path))
                {
                    File.Delete(file);
                }

                foreach (var subfolder in Directory.GetDirectories(path))
                {
                    Directory.Delete(subfolder, true);
                }
            }
            
        }

        public void Start(Server server)
        {
            string dockerComposeCommand = "docker-compose up -d";
            string path = $"./{server._name}";
            
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C cd {path} && {dockerComposeCommand}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            
            using (Process process = Process.Start(psi))
            {
                process.WaitForExit();
            }
            
        }

        public void Stop(Server server)
        {
            string dockerComposeCommand = "docker-compose down";
            string path = $"./{server._name}";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C cd {path} && {dockerComposeCommand}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(psi))
            {
                process.WaitForExit();
            }

        }
      
    }
}

