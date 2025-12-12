namespace MyMines.Models
{
    public class ServerConfiguration
    {
        public string Version { get; set; } = "1.20.2";
        public string Difficulty { get; set; } = "HARD";
        public int MaxPlayers { get; set; } = 10;
        public string Memory { get; set; } = "3G";
        public bool AllowFlight { get; set; } = true;
        public bool OnlineMode { get; set; } = false;
        public bool EnableWhitelist { get; set; } = false;

        public Dictionary<string, string> ToEnvironmentVariables()
        {
            return new Dictionary<string, string>
            {
                { "EULA", "TRUE" },
                { "DEBUG", "true" },
                { "VERSION", Version },
                { "DIFFICULTY", Difficulty },
                { "MAX_PLAYERS", MaxPlayers.ToString() },
                { "ALLOW_FLIGHT", AllowFlight.ToString().ToUpper() },
                { "MAX_MEMORY", Memory },
                { "ONLINE_MODE", OnlineMode.ToString().ToUpper() },
                { "OVERRIDE_SERVER_PROPERTIES", "true" },
                { "ENABLE_WHITELIST", EnableWhitelist.ToString().ToUpper() },
                { "ENFORCE_WHITELIST", EnableWhitelist.ToString().ToUpper() },
                { "LOG_TIMESTAMP", "true" },
                { "SNOOPER_ENABLED", "false" }
            };
        }
    }
}
