namespace Persistence.Configuration
{
    public class DatabaseSettings
    {
        public string Server { get; set; }

        public int Port { get; set; }

        public string Database { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public bool SecurityInfo { get; set; }

        public int Timeout { get; set; }
    }
}
