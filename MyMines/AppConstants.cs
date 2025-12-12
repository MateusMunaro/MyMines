namespace MyMines
{
    public static class AppConstants
    {
        public const string APP_NAME = "MyMines";
        public const string APP_VERSION = "1.0.0";
        
        public static class Docker
        {
            public const string IMAGE = "itzg/minecraft-server";
            public const string COMPOSE_FILE = "docker-compose.yml";
            public const int DEFAULT_PORT = 25565;
            public const string DEFAULT_MEMORY = "3G";
        }

        public static class Minecraft
        {
            public const string DEFAULT_VERSION = "LATEST";
            public const string DEFAULT_DIFFICULTY = "NORMAL";
            public const int DEFAULT_MAX_PLAYERS = 10;
            public const int MIN_PLAYERS = 1;
            public const int MAX_PLAYERS = 100;
        }

        public static class Folders
        {
            public const string DATA = "data";
            public const string MODS = "mods";
            public const string LOGS = "logs";
        }

        public static class Messages
        {
            public const string SERVER_CREATED = "Servidor criado com sucesso!";
            public const string SERVER_STARTED = "Servidor iniciado com sucesso!";
            public const string SERVER_STOPPED = "Servidor parado com sucesso!";
            public const string SERVER_DELETED = "Servidor deletado com sucesso!";
            
            public const string ERROR_NO_DOCKER = "Docker não está instalado ou em execução.";
            public const string ERROR_NO_COMPOSE = "Docker Compose não está instalado.";
            public const string ERROR_INVALID_NAME = "Nome do servidor inválido.";
            public const string ERROR_SERVER_EXISTS = "Já existe um servidor com este nome.";
        }
    }
}
