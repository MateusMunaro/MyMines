namespace MyMines.Services
{
    public static class ValidationHelper
    {
        public static bool IsValidServerName(string name, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                errorMessage = "O nome do servidor não pode estar vazio.";
                return false;
            }

            if (name.Length < 3)
            {
                errorMessage = "O nome do servidor deve ter pelo menos 3 caracteres.";
                return false;
            }

            if (name.Length > 50)
            {
                errorMessage = "O nome do servidor não pode ter mais de 50 caracteres.";
                return false;
            }

            if (name.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                errorMessage = "O nome do servidor contém caracteres inválidos.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public static bool IsValidPort(int port, out string errorMessage)
        {
            if (port < 1024 || port > 65535)
            {
                errorMessage = "A porta deve estar entre 1024 e 65535.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public static bool IsValidMemory(string memory, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(memory))
            {
                errorMessage = "A memória não pode estar vazia.";
                return false;
            }

            var regex = new System.Text.RegularExpressions.Regex(@"^\d+[MGmg]$");
            if (!regex.IsMatch(memory))
            {
                errorMessage = "Formato de memória inválido. Use formato como '2G' ou '512M'.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}
